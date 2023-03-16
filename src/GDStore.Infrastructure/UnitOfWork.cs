using GDStore.Application.Interfaces;
using GDStore.Application.Interfaces.Repositories;
using GDStore.Infrastructure.Persistence;
using GDStore.Infrastructure.Repositories;
using System.Threading.Tasks;

namespace GDStore.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GDStoreDbContext _context;
        private IBrandRepository _brandRepository;
        private ICategoryRepository _categoryRepository;
        private IProductRepository _productRepository;
        private IProductImageRepository _productImageRepository;
        private IProductCategoryRepository _productCategoryRepository;
        public IBrandRepository Brands => _brandRepository ?? (_brandRepository = new BrandRepository(_context));
        public ICategoryRepository Categories => _categoryRepository ?? (_categoryRepository = new CategoryRepository(_context));
        public IProductRepository Products => _productRepository ?? (_productRepository = new ProductRepository(_context));
        public IProductImageRepository ProductImages => _productImageRepository ?? (_productImageRepository = new ProductImageRepository(_context));
        public IProductCategoryRepository ProductCategories => _productCategoryRepository ?? (_productCategoryRepository = new ProductCategoryRepository(_context));
        public UnitOfWork(GDStoreDbContext context)
        {
            _context = context;
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
