using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.Composite
{
    class Component : IComponent<string>
    {
        private string Name { get; set; }

        public Component(string name)
        {
            this.Name = name;
        }

        public void Add(IComponent<string> element)
        {
            throw new Exception("Component doesn't support adding child components");
        }

        public void Display()
        {
            Console.WriteLine($"Component (Child): {this.Name}");
        }
    }
}
