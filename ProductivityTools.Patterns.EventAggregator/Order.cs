using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.EventAggregator
{
    class Order
    {
         

        public void PlaceOrder()
        {
            Console.WriteLine("Order placed");
            EventAggregator.Publish(new OrderAddedEvent());
        }
    }
}
