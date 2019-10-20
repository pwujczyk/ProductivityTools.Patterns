using System;

namespace ProductivityTools.Patterns.EventAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RaportingModule raportingModule = new RaportingModule();
            EventAggregator.Subscribe(raportingModule);

            Order order = new Order();
            order.PlaceOrder();

            Console.ReadLine();
        }
    }
}
