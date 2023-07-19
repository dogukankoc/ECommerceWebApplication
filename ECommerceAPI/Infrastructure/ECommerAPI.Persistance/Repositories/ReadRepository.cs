using ECommerAPI.Persistance.Contexts;
using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ECommerAPI.Persistance.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ECommerceAPIDbContext _context;
        public ReadRepository(ECommerceAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();
        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
            {
                query = query.AsNoTracking(); //Eğerki verilerin izlenmesini istemiyorsam Trackingi kesiyorum.Trackinge gerek yoksa kesiyorum ve maliyeti düşürüyorum
            }
            return query;
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.Where(method);
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return query;
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if(!tracking)
            {
                query = Table.AsNoTracking();
            }
            return await query.FirstOrDefaultAsync(method);
        }

        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if(!tracking)
            {
                query = Table.AsNoTracking();
            }
            //IQuaeryable'da çalışıyorsan FindAsync fonksiyonu yoktur. Böyle bir durumda marker interface'ini kullanmak zorunda kalacaksın. FirstOrDefaultu kullanacaksın.Yİne başa döndük yani :D
            return await query.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
        }
    }
}
