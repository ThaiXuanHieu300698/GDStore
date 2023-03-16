using GDStore.Application.Interfaces.Repositories;
using GDStore.Domain.Entities;
using GDStore.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace GDStore.Infrastructure.Repositories
{
    public class ProductImageRepository : RepositoryBase<ProductImage>, IProductImageRepository
    {
        public ProductImageRepository(GDStoreDbContext context) : base(context)
        {

        }
    }
}
