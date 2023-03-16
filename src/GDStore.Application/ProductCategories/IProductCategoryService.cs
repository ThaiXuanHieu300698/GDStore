using GDStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GDStore.Application.ProductCategories
{
    public interface IProductCategoryService
    {
        Task Add(ProductCategory productCategory);
        Task Update(ProductCategory productCategory);
        Task Delete(int productId);
        Task<ProductCategory> GetByProductCategoryId(int productId, int categoryId);
        Task<IEnumerable<ProductCategory>> GetByProductId(int productId);
    }
}
