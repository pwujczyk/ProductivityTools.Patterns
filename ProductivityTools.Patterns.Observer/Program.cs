using System;

namespace ProductivityTools.Patterns.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CreditCard card = new CreditCard();
            AmlObserver observer = new AmlObserver(card);
            card.Pay();
            Console.ReadLine();
        }
    }
}
