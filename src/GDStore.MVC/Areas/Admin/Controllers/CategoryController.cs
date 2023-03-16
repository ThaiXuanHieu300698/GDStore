using System;
using System.Threading.Tasks;
using GDStore.MVC.Services;
using GDStore.ViewModel.Categories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;

namespace GDStore.MVC.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryApiClient _categoryApiClient;
        public CategoryController(ICategoryApiClient categoryApiClient)
        {
            _categoryApiClient = categoryApiClient;
        }
        public async Task<IActionResult> List()
        {
            var data = await _categoryApiClient.GetAll();
            return View(data);
        }

        public async Task<IActionResult> Save(string strCategory)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            CategoryVm categoryVm = serializer.Deserialize<CategoryVm>(strCategory);

            bool status = false;

            if (categoryVm.Id == 0)
            {
                var request = new CategoryCreateRequest();
                request.Name = categoryVm.Name;
                request.Description = categoryVm.Description;
                request.UserId = new Guid("69bd714f-9576-45ba-b5b7-f00649be00de");
                request.CreatedDate = DateTime.Now;

                status = await _categoryApiClient.Add(request);
            }
            else
            {
                var request = new CategoryUpdateRequest();
                request.Id = categoryVm.Id;
                request.Name = categoryVm.Name;
                request.Description = categoryVm.Description;
                request.UserId = new Guid("69bd714f-9576-45ba-b5b7-f00649be00de");
                request.CreatedDate = DateTime.Now;

                status = await _categoryApiClient.Update(request);
            }

            return Json(new { status = status });
        }

        public async Task<IActionResult> Get(int categoryId)
        {
            bool status = false;
            var data = await _categoryApiClient.Get(categoryId);
            if (data == null)
            {
                status = false;
            }
            else
            {
                status = true;
            }
            return Json(new { data = data, status = status });
        }

        public async Task<IActionResult> Delete(int categoryId)
        {
            bool status = false;
            status = await _categoryApiClient.Delete(categoryId);

            return Json(new { status = status });
        }
    }
}
