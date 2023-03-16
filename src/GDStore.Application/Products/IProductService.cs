using GDStore.ViewModel.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GDStore.Application.Products
{
    public interface IProductService
    {
        Task<IEnumerable<ProductVm>> GetProducts();
        Task<ProductVm> GetById(int id);
        Task Add(ProductCreateRequest request);
        Task Update(ProductUpdateRequest request);
        Task Delete(int id);
    }
}
