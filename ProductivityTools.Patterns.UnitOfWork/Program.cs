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


           
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
