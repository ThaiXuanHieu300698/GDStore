using GDStore.ViewModel.Brands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDStore.MVC.Services
{
    public interface IBrandApiClient
    {
        Task<IEnumerable<BrandVm>> GetAll();
        Task<BrandVm> Get(int id);
    }
}
