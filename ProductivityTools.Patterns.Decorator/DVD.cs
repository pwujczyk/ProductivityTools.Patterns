using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.Decorator
{
    class DVD : LibraryItem
    {
        public DVD(string title)
        {
            base.Title = title;
        }

        public override void Display()
        {
            Console.WriteLine($"DVD: {base.Title}");
        }
    }
}
