﻿using ECommerAPI.Persistance.Contexts;
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
        public IQueryable<T> GetAll() => Table;
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method) => Table.Where(method);
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method) => await Table.FirstOrDefaultAsync(method);
        public async Task<T> GetByIdAsync(string id) => await Table.FindAsync(Guid.Parse(id));
            //await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
    }
}
