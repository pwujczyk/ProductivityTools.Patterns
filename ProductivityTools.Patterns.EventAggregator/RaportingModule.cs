using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.EventAggregator
{
    class RaportingModule : IEvent<OrderAddedEvent>
    {
        public void OnEvent(OrderAddedEvent t)
        {
            Console.WriteLine("Raporting Module perfroms raport from order");
        }
    }
}
