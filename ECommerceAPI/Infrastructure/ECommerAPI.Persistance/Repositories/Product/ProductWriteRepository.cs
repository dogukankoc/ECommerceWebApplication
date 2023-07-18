using ECommerAPI.Persistance.Contexts;
using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities;

namespace ECommerAPI.Persistance.Repositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
