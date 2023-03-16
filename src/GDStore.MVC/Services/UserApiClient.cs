using GDStore.Application.Common;
using GDStore.Application.Models;
using GDStore.ViewModel.Users;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GDStore.MVC.Services
{
    public class UserApiClient : BaseApiClient, IUserApiClient
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _config;
        public UserApiClient(HttpClient client, IConfiguration config) : base(client, config)
        {
            _client = client;
            _config = config;
        }

        public async Task<ApiResult<bool>> Delete(Guid id)
        {
            _client.BaseAddress = new Uri(_config[Constants.AppSettings.BaseAddress]);
            var response = await _client.DeleteAsync($"/api/users/{id}");
            var result = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(result);

            return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(result);
        }

        public async Task<IEnumerable<UserVm>> GetAll()
        {
            return await GetListAsync<UserVm>("/api/users");
        }

        public async Task<ApiResult<UserVm>> GetUser(Guid id)
        {
            _client.BaseAddress = new Uri(_config[Constants.AppSettings.BaseAddress]);
            var response = await _client.GetAsync($"/api/users/{id}");
            var result = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<ApiSuccessResult<UserVm>>(result);

            return JsonConvert.DeserializeObject<ApiErrorResult<UserVm>>(result);
        }

        public async Task<ApiResult<string>> Login(LoginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            _client.BaseAddress = new Uri(_config[Constants.AppSettings.BaseAddress]);
            var response = await _client.PostAsync("/api/users/login", httpContent);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ApiSuccessResult<string>>(await response.Content.ReadAsStringAsync());
            }
            return JsonConvert.DeserializeObject<ApiErrorResult<string>>(await response.Content.ReadAsStringAsync());
        }

        public async Task<ApiResult<bool>> Register(RegisterRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            _client.BaseAddress = new Uri(_config[Constants.AppSettings.BaseAddress]);
            var response = await _client.PostAsync("/api/users/", httpContent);
            var result = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(result);

            return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(result);
        }

        public async Task<ApiResult<bool>> Update(Guid id, UserUpdateRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            _client.BaseAddress = new Uri(_config[Constants.AppSettings.BaseAddress]);
            var response = await _client.PutAsync($"/api/users/{id}", httpContent);
            var result = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(result);

            return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(result);
        }
    }
}
