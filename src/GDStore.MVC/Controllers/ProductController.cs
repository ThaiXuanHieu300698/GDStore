using GDStore.Application.Common;
using GDStore.MVC.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace GDStore.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly ICategoryApiClient _categoryApiClient;
        private readonly IConfiguration _config;
        public ProductController(IProductApiClient productApiClient, ICategoryApiClient categoryApiClient,
            IConfiguration config)
        {
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
            _config = config;
        }

        [Route("san-pham/{slug}-{id:int}")]
        public async Task<IActionResult> Detail(int id)
        {
            TempData["BackendUrl"] = _config[Constants.AppSettings.BaseAddress];
            var product = await _productApiClient.GetById(id);
            return View(product);
        }
        
    }
}
