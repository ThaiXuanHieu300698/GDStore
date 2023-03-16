using GDStore.Application.Models;
using GDStore.ViewModel.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDStore.MVC.Services
{
    public interface IUserApiClient
    {
        Task<ApiResult<string>> Login(LoginRequest request);
        Task<ApiResult<bool>> Register(RegisterRequest request);
        Task<IEnumerable<UserVm>> GetAll();
        Task<ApiResult<UserVm>> GetUser(Guid id);
        Task<ApiResult<bool>> Update(Guid id, UserUpdateRequest request);
        Task<ApiResult<bool>> Delete(Guid id);
    }
}
