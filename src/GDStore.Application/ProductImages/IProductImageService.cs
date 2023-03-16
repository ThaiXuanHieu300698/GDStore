using GDStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GDStore.Application.ProductImages
{
    public interface IProductImageService
    {
        Task Add(ProductImage productImage);
        Task Update(ProductImage productImage);
        Task Delete(int productId);
        Task<ProductImage> GetById(int id);
        Task<IEnumerable<ProductImage>> GetByProductId(int productId);
    }
}
