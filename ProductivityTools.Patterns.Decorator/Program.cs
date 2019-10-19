using System;

namespace ProductivityTools.Patterns.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Book book = new Book("Batman");
            book.Display();
            Console.WriteLine("===============");

            BorrowableLibraryItem borrowedbook = new BorrowableLibraryItem(book);
            borrowedbook.IsLent = true;
            borrowedbook.Display();
            Console.ReadLine();
        }
    }
}
