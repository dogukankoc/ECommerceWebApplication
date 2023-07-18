using ECommerAPI.Persistance.Contexts;
using ECommerceAPI.Application.Repositories;

namespace ECommerAPI.Persistance.Repositories
{
    public class CustomerWriteRepository : WriteRepository<ECommerceAPI.Domain.Entities.Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
