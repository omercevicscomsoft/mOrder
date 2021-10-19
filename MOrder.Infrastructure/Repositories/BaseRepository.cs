using Microsoft.EntityFrameworkCore;
using MOrder.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MOrder.Infrastructure.Repositories
{
    internal abstract class BaseRepository<T> where T : class
    {
        private readonly DBContext _context;

        public BaseRepository(DBContext context)
        {
            _context = context;
        }

        protected T Create(T entity)
        {
            return _context.Set<T>().Add(entity).Entity;
        }
        protected IQueryable<T> Entity(bool trackChanges)
        {
            if (!trackChanges)
                return this._context.Set<T>().AsNoTracking();
            return this._context.Set<T>();
        }
        protected T Update(T entity)
        {
            return this._context.Set<T>().Update(entity).Entity;
        }
        protected void Delete(T entity)
        {
            this._context.Set<T>().Remove(entity);
        }
    }
}
