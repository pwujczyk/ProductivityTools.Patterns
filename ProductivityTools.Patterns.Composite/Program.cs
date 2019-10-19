using System;

namespace ProductivityTools.Patterns.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Component component = new Component("Day");
            Composite composite = new Composite("Year");
            composite.Add(component);
            composite.Display();

            Console.WriteLine("=============");
            Component componentMinute = new Component("Minute");
            Composite compositeDay = new Composite("Day");
            compositeDay.Add(componentMinute);
            Composite compositeYear = new Composite("Year");
            compositeYear.Add(compositeDay);
            compositeYear.Display();

            Console.ReadLine();
        }
    }
}
