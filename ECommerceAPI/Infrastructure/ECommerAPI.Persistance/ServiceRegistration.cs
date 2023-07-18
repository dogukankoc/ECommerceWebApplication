using ECommerAPI.Persistance.Contexts;
using ECommerAPI.Persistance.Repositories;
using ECommerceAPI.Application.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerAPI.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            //adding  DbContext in Built-in IoC Container and using PostgreSQL
            services.AddDbContext<ECommerceAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));

            //DbContext nesnesi  hangi lifetime'a sahipse Repository Servislerimizide o lifetimeda yapmak daha sağlıklı olacaktır. DbContext lifetiem default olarak Scoped
            //adding Repository Services
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
 