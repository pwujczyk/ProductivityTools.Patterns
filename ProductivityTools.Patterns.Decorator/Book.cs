using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.Decorator
{
    class Book : LibraryItem
    {
        public Book(string title)
        {
            this.Title = title;
        }
        public override void Display()
        {
            Console.WriteLine($"Book: {base.Title}");
        }
    }
}
