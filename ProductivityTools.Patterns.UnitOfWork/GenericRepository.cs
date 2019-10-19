using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductivityTools.Patterns.UnitOfWork
{
    class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly UowDbContext Context;
        private DbSet<T> dbSet => this.Context.Set<T>();
        public IQueryable<T> Entities => throw new NotImplementedException();

        public GenericRepository(UowDbContext context)
        {
            this.Context = context;
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
