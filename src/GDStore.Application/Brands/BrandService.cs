using GDStore.Application.Exceptions;
using GDStore.Application.Interfaces;
using GDStore.Domain.Entities;
using GDStore.ViewModel.Brands;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDStore.Application.Brands
{
    public class BrandService : IBrandService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BrandService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Add(BrandCreateRequest request)
        {
            var brand = new Brand();
            brand.Name = request.Name;
            brand.Logo = request.Logo;
            brand.CreatedDate = DateTime.Now;
            await _unitOfWork.Brands.Add(brand);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<IEnumerable<BrandVm>> GetBrands()
        {
            var brands = await _unitOfWork.Brands.GetAllAsync();
            var brandVm = brands.Select(c => new BrandVm
            {
                Id = c.Id,
                Name = c.Name,
                Logo = c.Logo
            });

            return brandVm;
        }

        public async Task Update(BrandUpdateRequest request)
        {
            var brand = await _unitOfWork.Brands.FirstOrDefaultAsync(b => b.Id == request.Id);
            if (brand == null)
            {
                throw new NotFoundException(nameof(Brand), request.Id);
            }

            brand.Name = request.Name;
            brand.Logo = request.Logo;

            _unitOfWork.Brands.Update(brand);
            await _unitOfWork.SaveChangeAsync();

        }

        public async Task Delete(int id)
        {
            var brand = await _unitOfWork.Brands.FirstOrDefaultAsync(b => b.Id == id);
            if (brand == null)
            {
                throw new NotFoundException(nameof(Brand), id);
            }

            _unitOfWork.Brands.Remove(brand);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<BrandVm> GetById(int id)
        {
            var brand = await _unitOfWork.Brands.FirstOrDefaultAsync(b => b.Id == id);
            if (brand == null)
            {
                throw new NotFoundException(nameof(Brand), id);
            }

            return new BrandVm(brand.Id, brand.Name, brand.Logo);
        }
    }
}
