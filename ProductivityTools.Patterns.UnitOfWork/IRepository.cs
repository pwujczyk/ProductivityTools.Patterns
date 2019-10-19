using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductivityTools.Patterns.UnitOfWork
{
    interface IRepository<T> where T:class
    {
        IQueryable<T> Entities { get; }
        void Add(T entity);
    }
}
