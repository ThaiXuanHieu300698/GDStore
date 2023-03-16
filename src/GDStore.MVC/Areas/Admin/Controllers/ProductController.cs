using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GDStore.Application.Common;
using GDStore.MVC.Services;
using GDStore.ViewModel.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;

namespace GDStore.MVC.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly ICategoryApiClient _categoryApiClient;
        private readonly IBrandApiClient _brandApiClient;
        private readonly IConfiguration _config;
        public ProductController(IProductApiClient productApiClient, ICategoryApiClient categoryApiClient,
            IBrandApiClient brandApiClient, IConfiguration config)
        {
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
            _brandApiClient = brandApiClient;
            _config = config;
        }
        public async Task<IActionResult> List()
        {
            TempData["BackendUrl"] = _config[Constants.AppSettings.BaseAddress];
            var products = await _productApiClient.GetAll();
            return View(products);
        }
        public async Task<IActionResult> Add()
        {
            var brands = await _brandApiClient.GetAll();
            ViewBag.Brands = brands.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            var categories = await _categoryApiClient.GetAll();
            ViewBag.Categories = categories.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            
            return View();
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> AddHandle([FromForm] ProductCreateRequest request, List<IFormFile> files)
        {
            if (files == null || files.Count == 0)
            {
                TempData["message"] = "Ảnh chưa được chọn";
                return View("Add");
            }
            if (!ModelState.IsValid)
            {
                TempData["message"] = "Thêm sản phẩm thất bại";
                return View("Add", request);
            }

            try
            {
                request.ThumbnailImage = files;
                var result = await _productApiClient.Add(request);
                if (result)
                {
                    TempData["message"] = "Thêm sản phẩm thành công";
                    return RedirectToAction("List");
                }
                TempData["message"] = "Thêm sản phẩm thất bại";
                return RedirectToAction("List");
            }
            catch (Exception)
            {
                TempData["message"] = "Thêm sản phẩm thất bại";
                return View("Add", request);
            }

        }

        public async Task<IActionResult> Edit(int id)
        {
            TempData["BackendUrl"] = _config[Constants.AppSettings.BaseAddress];
            var product = await _productApiClient.GetById(id);
            TempData["ProductImage"] = product.ThumbnailImage;
            var brands = await _brandApiClient.GetAll();
            ViewBag.Brands = brands.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString(),
                Selected = product.BrandId == x.Id
                
            });
            var categories = await _categoryApiClient.GetAll();
            ViewBag.Categories = categories.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString(),
                Selected = product.CategoryId.First() == x.Id
            });
            var productUpdate = new ProductUpdateRequest();
            productUpdate.Id = product.Id;
            productUpdate.Name = product.Name;
            productUpdate.OriginalPrice = product.OriginalPrice;
            productUpdate.Price = product.Price;
            productUpdate.Description = product.Description;
            productUpdate.BrandId = product.BrandId;

            return View(productUpdate);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> EditHandle([FromForm] ProductUpdateRequest request, List<IFormFile> files)
        {
            var product = await _productApiClient.GetById(request.Id);
            TempData["ProductImage"] = product.ThumbnailImage;
            TempData["BackendUrl"] = _config[Constants.AppSettings.BaseAddress];
            if (files == null || files.Count == 0)
            {
                TempData["message"] = "Ảnh chưa được chọn";
                return View("Edit");
            }
            if (!ModelState.IsValid)
            {
                TempData["message"] = "Cập nhật sản phẩm thất bại";
                return View("Edit", request);
            }

            try
            {
                request.ThumbnailImage = files;
                var result = await _productApiClient.Update(request);
                if (result)
                {
                    TempData["message"] = "Cập nhật sản phẩm thành công";
                    return RedirectToAction("List");
                }
                TempData["message"] = "Cập nhật sản phẩm thất bại";
                return RedirectToAction("List");
            }
            catch (Exception)
            {
                TempData["message"] = "Cập nhật sản phẩm thất bại";
                return View("Edit", request);
            }

        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _productApiClient.Delete(id);
            if (result)
            {
                TempData["message"] = "Xóa sản phẩm thành công";
                return RedirectToAction("List");
            }
            else
            {
                TempData["message"] = "Xóa sản phẩm thất bại";
                return RedirectToAction("List");
            }
        }

    }
}
