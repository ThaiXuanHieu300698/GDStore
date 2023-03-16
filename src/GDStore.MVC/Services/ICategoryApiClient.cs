using GDStore.ViewModel.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDStore.MVC.Services
{
    public interface ICategoryApiClient
    {
        Task<IEnumerable<CategoryVm>> GetAll();
        Task<CategoryVm> Get(int id);
        Task<bool> Add(CategoryCreateRequest request);
        Task<bool> Update(CategoryUpdateRequest request);
        Task<bool> Delete(int id);
    }
}
