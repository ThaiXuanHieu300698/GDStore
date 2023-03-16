using GDStore.Application.Models;
using GDStore.ViewModel.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GDStore.Application.Users
{
    public interface IUserService
    {
        Task<ApiResult<string>> Login(LoginRequest request);
        Task<ApiResult<bool>> Register(RegisterRequest request);
        Task<IEnumerable<UserVm>> GetUsers();
        Task<ApiResult<UserVm>> GetUser(Guid id);
        Task<ApiResult<bool>> Update(Guid id, UserUpdateRequest request);
        Task<ApiResult<bool>> Delete(Guid id);
    }
}
