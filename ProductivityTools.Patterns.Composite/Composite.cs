using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.Composite
{
    class Composite : IComponent<string>
    {
        public string Name { get; set; }
        List<IComponent<string>> list = new List<IComponent<string>>();

        public Composite(string name)
        {
            this.Name = name;
        }

        public void Add(IComponent<string> component)
        {
            this.list.Add(component);
        }

        public void Display()
        {
            Console.WriteLine($"Comosite (Parent) {this.Name}");
            foreach (var item in this.list)
            {
                item.Display();
            }
        }
    }
}
