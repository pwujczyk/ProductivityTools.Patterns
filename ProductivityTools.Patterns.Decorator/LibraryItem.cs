using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.Decorator
{
    abstract class LibraryItem
    {
        protected string Title;
        public abstract void Display();
    }
}
