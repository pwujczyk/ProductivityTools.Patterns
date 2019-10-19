using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.Composite
{
    interface IComponent<T>
    {
        void Display();
        void Add(IComponent<T> element);
    }
}
