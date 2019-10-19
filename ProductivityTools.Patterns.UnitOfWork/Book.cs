using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.UnitOfWork
{
    class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
    }
}
