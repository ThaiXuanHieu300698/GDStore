using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GDStore.MVC.Services;
using GDStore.ViewModel.Users;
using Microsoft.AspNetCore.Mvc;

namespace GDStore.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IUserApiClient _userApiClient;

        public UserController(IUserApiClient userApiClient)
        {
            _userApiClient = userApiClient;
        }
        public async Task<IActionResult> List()
        {
            var users = await _userApiClient.GetAll();
            return View(users);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromForm] RegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var result = await _userApiClient.Register(request);
            if (result.IsSuccessed)
            {
                TempData["message"] = "Thêm người dùng thành công";
                return RedirectToAction("List");
            }

            return View(request);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var result = await _userApiClient.GetUser(id);
            if (result.IsSuccessed)
            {
                var userVm = result.ResultObj;
                var userUpdateRequest = new UserUpdateRequest()
                {
                    FirstName = userVm.FirstName,
                    LastName = userVm.LastName,
                    Email = userVm.Email,
                    PhoneNumber = userVm.PhoneNumber,
                    Id = id
                };
                return View(userUpdateRequest);
            }
            return RedirectToAction("Error", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UserUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _userApiClient.Update(request.Id, request);
            if (result.IsSuccessed)
            {
                TempData["result"] = "Cập nhật người dùng thành công";
                return RedirectToAction("List");
            }

            return View(request);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _userApiClient.Delete(id);
            if (result.IsSuccessed)
            {
                TempData["result"] = "Xóa người dùng thành công";
                return RedirectToAction("List");
            }

            TempData["result"] = "Xóa người dùng thất bại";
            return RedirectToAction("List");
        }
    }
}
