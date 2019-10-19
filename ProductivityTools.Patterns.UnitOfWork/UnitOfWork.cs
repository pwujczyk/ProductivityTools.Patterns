using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductivityTools.Patterns.UnitOfWork
{
    class UnitOfWork : IUnitOfWork
    {
        UowDbContext Context;

        public IRepository<Author> Autors => new GenericRepository<Author>(Context);

        public IRepository<Bentonite> Bentonite => new GenericRepository<Bentonite>(Context);

        public UnitOfWork(UowDbContext context)
        {
            this.Context = context;
        }

        public void Commit()
        {
            this.Context.SaveChanges();
        }

        public void RejectChanges()
        {
            foreach (var entry in Context.ChangeTracker.Entries().Where(e => e.State != EntityState.Unchanged))
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }
    }
}
