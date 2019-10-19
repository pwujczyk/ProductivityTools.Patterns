using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.UnitOfWork
{
    interface IUnitOfWork
    {
        IRepository<Author> Autors { get; }
        IRepository<Bentonite> Bentonite { get; }

        void Commit();
        void RejectChanges();
    }
}
