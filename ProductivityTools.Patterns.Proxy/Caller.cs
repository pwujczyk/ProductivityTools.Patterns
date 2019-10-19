using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.Proxy
{
    class Caller:ICaller
    {
        public void Call()
        {
            Console.WriteLine("Caller performed a call");
        }
    }
}
