using GDStore.Application.Interfaces;
using GDStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GDStore.Application.ProductImages
{
    public class ProductImageService : IProductImageService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductImageService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task Add(ProductImage productImage)
        {
            await _unitOfWork.ProductImages.Add(productImage);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task Update(ProductImage productImage)
        {
            _unitOfWork.ProductImages.Update(productImage);
            await _unitOfWork.SaveChangeAsync();
        }
        public async Task Delete(int productId)
        {
            var productImages = await _unitOfWork.ProductImages.FindAsync(x => x.ProductId == productId);
            foreach(var item in productImages)
            {
                _unitOfWork.ProductImages.Remove(item);
            }
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<IEnumerable<ProductImage>> GetByProductId(int productId)
        {
            return await _unitOfWork.ProductImages.FindAsync(x => x.ProductId == productId);
        }

        public async Task<ProductImage> GetById(int id)
        {
            return await _unitOfWork.ProductImages.GetByIdAsync(id);
        }
    }
}
