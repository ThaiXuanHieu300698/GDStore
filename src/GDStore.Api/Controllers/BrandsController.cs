using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GDStore.Application.Brands;
using GDStore.ViewModel.Brands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace GDStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }    

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var brands = await _brandService.GetBrands();
            return Ok(brands);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var brand = await _brandService.GetById(id);
            return Ok(brand);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromForm] BrandCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _brandService.Add(request);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromForm] BrandUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _brandService.Update(request);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _brandService.Delete(id);
            return Ok();
        }
    }
}
