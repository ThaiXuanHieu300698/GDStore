using GDStore.Domain.Entities;
using GDStore.ViewModel.Brands;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GDStore.Application.Brands
{
    public interface IBrandService
    {
        Task<IEnumerable<BrandVm>> GetBrands();
        Task<BrandVm> GetById(int id);
        Task Add(BrandCreateRequest request);
        Task Update(BrandUpdateRequest request);
        Task Delete(int id);
    }
}
