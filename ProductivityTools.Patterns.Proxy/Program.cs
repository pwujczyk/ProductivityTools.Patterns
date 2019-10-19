using System;

namespace ProductivityTools.Patterns.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Caller caller = new Caller();
            caller.Call();
            Console.WriteLine("=========");
            Proxy proxy = new Proxy();
            proxy.Call();

            Console.ReadLine();
        }
    }
}
