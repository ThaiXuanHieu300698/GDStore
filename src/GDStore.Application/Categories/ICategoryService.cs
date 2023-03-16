using GDStore.Domain.Entities;
using GDStore.ViewModel.Categories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GDStore.Application.Categories
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryVm>> GetCategories();
        Task<CategoryVm> GetById(int id);
        Task Add(CategoryCreateRequest request);
        Task Update(CategoryUpdateRequest request);
        Task Delete(int id);
    }
}
