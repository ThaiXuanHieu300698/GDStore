using GDStore.Application.Exceptions;
using GDStore.Application.Interfaces;
using GDStore.Application.ProductCategories;
using GDStore.Application.ProductImages;
using GDStore.Domain.Entities;
using GDStore.ViewModel.Products;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GDStore.Application.Products
{
    public class ProductService : IProductService
    {
        private readonly IStorageService _storageService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductImageService _productImageService;
        private readonly IProductCategoryService _productCategoryService;
        public ProductService(IStorageService storageService, IUnitOfWork unitOfWork, IProductImageService productImageService,
            IProductCategoryService productCategoryService)
        {
            _storageService = storageService;
            _unitOfWork = unitOfWork;
            _productImageService = productImageService;
            _productCategoryService = productCategoryService;
        }
        public async Task Add(ProductCreateRequest request)
        {
            var productNew = new Product();
            productNew.Name = request.Name;
            productNew.Price = request.Price;
            productNew.OriginalPrice = request.OriginalPrice;
            productNew.Description = request.Description;
            productNew.BrandId = request.BrandId;
            productNew.CreatedDate = DateTime.Now;
            var product = await _unitOfWork.Products.AddEntity(productNew);
            await _unitOfWork.SaveChangeAsync();

            var productCategory = new ProductCategory
            {
                ProductId = product.Id,
                CategoryId = request.CategoryIds.First()
            };

            await _productCategoryService.Add(productCategory);

            if (request.ThumbnailImage.Count != 0)
            {
                foreach (var i in request.ThumbnailImage)
                {
                    await _productImageService.Add(
                        new ProductImage()
                        {
                            Description = "Thumbnai Image",
                            CreatedDate = DateTime.Now,
                            IsDefault = true,
                            ProductId = product.Id,
                            Url = await this.SaveFile(i)
                        }
                    );
                }
            }
        }

        public async Task Delete(int id)
        {
            var product = await _unitOfWork.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
            {
                throw new NotFoundException(nameof(Product), id);
            }

            _unitOfWork.Products.Remove(product);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<ProductVm> GetById(int id)
        {
            var product = await _unitOfWork.Products.FirstOrDefaultAsync(c => c.Id == id);
            var productCategory = await _productCategoryService.GetByProductId(product.Id);
            if (product == null)
            {
                throw new NotFoundException(nameof(Product), id);
            }
            var productImages = await _productImageService.GetByProductId(product.Id);
            var productVm = new ProductVm
            {
                Id = product.Id,
                Name = product.Name,
                OriginalPrice = product.OriginalPrice,
                Price = product.Price,
                Description = product.Description,
                CreatedDate = product.CreatedDate,
                Rating = product.Rating,
                ThumbnailImage = productImages,
                BrandId = product.BrandId,
                CategoryId = productCategory.Select(x => x.CategoryId).ToList()
            };

            return productVm;
        }
        public async Task<IEnumerable<ProductVm>> GetProducts()
        {
            var products = await _unitOfWork.Products.GetAllAsync();
            var listProductVm = new List<ProductVm>();
            foreach (var item in products)
            {
                var productCategory = await _productCategoryService.GetByProductId(item.Id);
                var productVmItem = new ProductVm();
                productVmItem.Id = item.Id;
                productVmItem.Name = item.Name;
                productVmItem.OriginalPrice = item.OriginalPrice;
                productVmItem.Price = item.Price;
                productVmItem.Description = item.Description;
                productVmItem.CreatedDate = item.CreatedDate;
                productVmItem.Rating = item.Rating;
                productVmItem.BrandId = item.BrandId;
                productVmItem.CategoryId = productCategory.Select(x => x.CategoryId).ToList();
                productVmItem.ThumbnailImage = await _productImageService.GetByProductId(item.Id);
                listProductVm.Add(productVmItem);
            }

            return listProductVm;
        }

        public async Task Update(ProductUpdateRequest request)
        {
            var product = await _unitOfWork.Products.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (product == null)
            {
                throw new NotFoundException(nameof(Product), request.Id);
            }
            product.Name = request.Name;
            product.Price = request.Price;
            product.OriginalPrice = request.OriginalPrice;
            product.Description = request.Description;
            product.BrandId = request.BrandId;
            product.CreatedDate = DateTime.Now;
            var productUpdate = _unitOfWork.Products.UpdateEntity(product);
            await _unitOfWork.SaveChangeAsync();
            var productCategory = new ProductCategory
            {
                ProductId = productUpdate.Id,
                CategoryId = request.CategoryIds.First()
            };
            await _productCategoryService.Update(productCategory);
            if (request.ThumbnailImage.Count != 0)
            {
                await _productImageService.Delete(request.Id);
                foreach (var i in request.ThumbnailImage)
                {
                    await _productImageService.Add(
                        new ProductImage()
                        {
                            Description = "Thumbnai Image",
                            CreatedDate = DateTime.Now,
                            Url = await this.SaveFile(i),
                            ProductId = productUpdate.Id,
                            IsDefault = true
                        }
                    );
                }
            }
        }
        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";

            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);

            return fileName;
        }
    }
}
