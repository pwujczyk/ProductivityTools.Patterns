using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.Proxy
{
    class Proxy : ICaller
    {
        private readonly ICaller Caller;

        public Proxy()
        {
            Caller = new Caller();
        }

        public void Call()
        {
            Console.WriteLine("Check done by Proxy");
            this.Caller.Call();

        }
    }
}
