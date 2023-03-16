using GDStore.MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace GDStore.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryApiClient _categoryApiClient;
        public CategoryController(ICategoryApiClient categoryApiClient)
        {
            _categoryApiClient = categoryApiClient;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
