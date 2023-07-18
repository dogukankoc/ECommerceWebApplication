using ECommerAPI.Persistance.Contexts;
using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities;

namespace ECommerAPI.Persistance.Repositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
