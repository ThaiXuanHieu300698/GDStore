using GDStore.Application.Interfaces.Repositories;
using System;
using System.Threading.Tasks;

namespace GDStore.Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBrandRepository Brands { get; }
        ICategoryRepository Categories { get; }
        IProductRepository Products { get; }
        IProductImageRepository ProductImages { get; }
        IProductCategoryRepository ProductCategories { get; }
        Task<int> SaveChangeAsync();
    }
}
