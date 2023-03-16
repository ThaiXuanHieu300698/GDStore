using GDStore.Application.Common;
using GDStore.MVC.Services;
using GDStore.ViewModel.Cart;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDStore.MVC.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly IConfiguration _config;
        public CartController(IProductApiClient productApiClient, IConfiguration config)
        {
            _productApiClient = productApiClient;
            _config = config;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListCart()
        {
            var cartSession = HttpContext.Session.GetString(Constants.CartSession);
            List<CartVm> currentCart = new List<CartVm>();
            if (cartSession != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartVm>>(cartSession);
            }
            return Ok(currentCart);
        }
        public async Task<IActionResult> AddToCart(int id)
        {
            var product = await _productApiClient.GetById(id);
            var cartSession = HttpContext.Session.GetString(Constants.CartSession);
            List<CartVm> currentCart = new List<CartVm>();
            if(cartSession != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartVm>>(cartSession);
            }

            int quantity = 1;
            if(currentCart.Any(x => x.ProductId == id))
            {
                quantity = currentCart.First(x => x.ProductId == id).Quantity + 1;
                var item = currentCart.Where(x => x.ProductId == id).FirstOrDefault();
                item.ProductId = product.Id;
                item.Name = product.Name;
                item.OriginalPrice = product.OriginalPrice;
                item.Price = product.Price;
                item.Quantity = quantity;
                item.ThumbnailImage = _config[Constants.AppSettings.BaseAddress] + "/user-content/" + product.ThumbnailImage.First().Url;
            }
            else
            {
                var cartVm = new CartVm()
                {
                    ProductId = id,
                    Name = product.Name,
                    OriginalPrice = product.OriginalPrice,
                    Price = product.Price,
                    Quantity = quantity,
                    ThumbnailImage = _config[Constants.AppSettings.BaseAddress] + "/user-content/" + product.ThumbnailImage.First().Url
                };

                currentCart.Add(cartVm);
            }
            
            HttpContext.Session.SetString(Constants.CartSession, JsonConvert.SerializeObject(currentCart));
            return Ok(currentCart);
        }

        public IActionResult UpdateCart(int id, int quantity)
        {
            var cartSession = HttpContext.Session.GetString(Constants.CartSession);
            List<CartVm> currentCart = currentCart = JsonConvert.DeserializeObject<List<CartVm>>(cartSession);
            foreach(var item in currentCart)
            {
                if(item.ProductId == id)
                {
                    if(quantity == 0)
                    {
                        currentCart.Remove(item);
                        break;
                    }
                    item.Quantity = quantity;
                }
            }
            HttpContext.Session.SetString(Constants.CartSession, JsonConvert.SerializeObject(currentCart));
            return Ok(currentCart);
        }
    }
}
