using GDStore.ViewModel.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDStore.MVC.Services
{
    public interface IProductApiClient
    {
        Task<IEnumerable<ProductVm>> GetAll();
        Task<ProductVm> GetById(int id);
        Task<bool> Add(ProductCreateRequest request);
        Task<bool> Update(ProductUpdateRequest request);
        Task<bool> Delete(int id);

    }
}
