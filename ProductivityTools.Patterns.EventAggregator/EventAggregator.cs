using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductivityTools.Patterns.EventAggregator
{
    static class EventAggregator
    {
        static Dictionary<Type, List<object>> EventList = new Dictionary<Type, List<object>>();

        public static void Subscribe(object o)
        {
            var eventTypes = o.GetType().GetInterfaces().Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IEvent<>));
            foreach (Type eventType in eventTypes)
            {
                List<object> objectList;
                if (EventList.TryGetValue(eventType, out objectList))
                {
                    objectList.Add(o);
                }
                else
                {
                    EventList.Add(eventType.GenericTypeArguments[0], new List<object> { o });
                }
            }
        }

        internal static void Publish<T>(T @event)
        {
            Type typeOfEventToPublish = typeof(T);
            List<object> objectList;
            if (EventList.TryGetValue(typeOfEventToPublish, out objectList))
            {
                foreach (IEvent<T> @object in objectList)
                {
                    @object.OnEvent(@event);
                }
            }
        }
    }
}
