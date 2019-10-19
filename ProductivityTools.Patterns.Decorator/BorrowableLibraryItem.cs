using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.Decorator
{
    //decorator
    class BorrowableLibraryItem:LibraryItem
    {
        public bool IsLent { get; set; }

        private readonly LibraryItem Item;

        public BorrowableLibraryItem(LibraryItem libraryitem)
        {
            this.Item = libraryitem;
        }

        public override void Display()
        {
            this.Item.Display();
            Console.WriteLine($"IsLent: {this.IsLent}");
        }
    }
}
