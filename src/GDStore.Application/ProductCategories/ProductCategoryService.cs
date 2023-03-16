using GDStore.Application.Interfaces;
using GDStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GDStore.Application.ProductCategories
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductCategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Add(ProductCategory productCategory)
        {
            await _unitOfWork.ProductCategories.Add(productCategory);
            await _unitOfWork.SaveChangeAsync();
        }

        public Task Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductCategory> GetByProductCategoryId(int productId, int categoryId)
        {
            return await _unitOfWork.ProductCategories.FirstOrDefaultAsync(x => x.ProductId == productId && x.CategoryId == categoryId);
        }

        public async Task<IEnumerable<ProductCategory>> GetByProductId(int productId)
        {
            return await _unitOfWork.ProductCategories.FindAsync(x => x.ProductId == productId);
        }

        public async Task Update(ProductCategory productCategory)
        {
            _unitOfWork.ProductCategories.Update(productCategory);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}
