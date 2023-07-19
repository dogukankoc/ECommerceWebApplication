﻿using ECommerceAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ECommerceAPI.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity 
    {
        IQueryable<T> GetAll(bool tracking = true); //EF Core Change Tracking default is true
        IQueryable<T> GetWhere(Expression<Func<T,bool>> method, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T,bool>> method, bool tracking = true); 
        Task<T> GetByIdAsync(string id, bool tracking = true);
    }
}
