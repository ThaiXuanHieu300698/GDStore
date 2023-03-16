using GDStore.Application.Common;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GDStore.MVC.Services
{
    public class BaseApiClient
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _config;

        protected BaseApiClient(HttpClient client,
                    IConfiguration config)
        {
            _config = config;
            _client = client;
        }
        protected async Task<TResponse> GetAsync<TResponse>(string url)
        {
            _client.BaseAddress = new Uri(_config[Constants.AppSettings.BaseAddress]);
            var response = await _client.GetAsync(url);
            
            return await response.Content.ReadFromJsonAsync<TResponse>();
        }

        public async Task<IEnumerable<T>> GetListAsync<T>(string url)
        {
            _client.BaseAddress = new Uri(_config[Constants.AppSettings.BaseAddress]);
            var response = await _client.GetAsync(url);

            return await response.Content.ReadFromJsonAsync<IEnumerable<T>>();
        }
    }
}
