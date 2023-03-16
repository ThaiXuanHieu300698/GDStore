using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GDStore.MVC.Models;
using GDStore.MVC.Services;
using Microsoft.Extensions.Configuration;
using GDStore.Application.Common;
using System.Threading.Tasks;
using GDStore.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace GDStore.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductApiClient _productApiClient;
        private readonly ICategoryApiClient _categoryApiClient;
        private readonly IConfiguration _config;
        public HomeController(ILogger<HomeController> logger, IProductApiClient productApiClient, IConfiguration config,
            ICategoryApiClient categoryApiClient)
        {
            _logger = logger;
            _productApiClient = productApiClient;
            _config = config;
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IActionResult> Index()
        {
            TempData["BackendUrl"] = _config[Constants.AppSettings.BaseAddress];
            ViewBag.Categories = await _categoryApiClient.GetAll();
            var products = await _productApiClient.GetAll();
            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Policy()
        {
            return View();
        }
    }
}
