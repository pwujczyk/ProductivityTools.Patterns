using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.EventAggregator
{
    interface IEvent<T>
    {
        void OnEvent(T t);
    }
}
