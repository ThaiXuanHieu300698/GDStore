using GDStore.ViewModel.Brands;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GDStore.MVC.Services
{
    public class BrandApiClient : BaseApiClient, IBrandApiClient
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _config;
        public BrandApiClient(HttpClient client, IConfiguration config) : base(client, config)
        {
            _client = client;
            _config = config;
        }

        public async Task<BrandVm> Get(int id)
        {
            return await GetAsync<BrandVm>("/api/brands" +id);
        }

        public async Task<IEnumerable<BrandVm>> GetAll()
        {
            return await GetListAsync<BrandVm>("/api/brands");
        }

    }
}
