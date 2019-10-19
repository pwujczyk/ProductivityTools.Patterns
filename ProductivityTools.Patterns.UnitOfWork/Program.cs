using Microsoft.EntityFrameworkCore;
using System;

namespace ProductivityTools.Patterns.UnitOfWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQL2017;Initial Catalog=UOW;Integrated Security=True");
            UowDbContext dbContext = new UowDbContext(optionsBuilder.Options);
            dbContext.Database.EnsureCreated();

            var author = new Author() { Name = "Lee Child" };
            var bentonite = new Bentonite() { Name = "Hard" };

            var unitOfWork = new UnitOfWork(dbContext);
            unitOfWork.Autors.Add(author);
            unitOfWork.Bentonite.Add(bentonite);
            unitOfWork.Commit();

            var element = unitOfWork.Autors.Entities.FirstAsync();

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
