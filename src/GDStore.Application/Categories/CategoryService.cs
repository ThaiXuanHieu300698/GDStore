using GDStore.Application.Exceptions;
using GDStore.Application.Interfaces;
using GDStore.Domain.Entities;
using GDStore.ViewModel.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDStore.Application.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Add(CategoryCreateRequest request)
        {
            var category = new Category();
            category.Name = request.Name;
            category.Description = request.Description;
            category.CreatedDate = DateTime.Now;
            category.IsShowOnHome = false;

            await _unitOfWork.Categories.Add(category);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task Delete(int id)
        {
            var category = await _unitOfWork.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if(category == null)
            {
                throw new NotFoundException(nameof(Category), id);
            }    
            _unitOfWork.Categories.Remove(category);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<IEnumerable<CategoryVm>> GetCategories()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync();
            
            return categories.Select(c => new CategoryVm
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description,
                CreatedDate = c.CreatedDate,
                IsShowOnHome = c.IsShowOnHome
            });
        }

        public async Task<CategoryVm> GetById(int id)
        {
            var category = await _unitOfWork.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (category == null)
            {
                throw new NotFoundException(nameof(Category), id);
            }
            return new CategoryVm(category.Id, category.Name, category.Description, category.CreatedDate, category.IsShowOnHome);
        }

        public async Task Update(CategoryUpdateRequest request)
        {
            var category = await _unitOfWork.Categories.FirstOrDefaultAsync(c => c.Id == request.Id);
            if (category == null)
            {
                throw new NotFoundException(nameof(Category), request.Id);
            }
            category.Name = request.Name;
            category.Description = request.Description;
            category.CreatedDate = DateTime.Now;
            category.IsShowOnHome = false;

            _unitOfWork.Categories.Update(category);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}
