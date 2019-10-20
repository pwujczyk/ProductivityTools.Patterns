using System;

namespace ProductivityTools.Patterns.Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Document document = new Document();
            document.Add(new PlainText("Pawel"));
            document.Add(new BoldText("Wujczyk"));


            Console.WriteLine("Plain text:");
            Console.WriteLine(document.ToPlainText());
            Console.WriteLine("HTML text:");
            Console.WriteLine(document.ToHtml());

            Console.ReadLine();
            
        }
    }
}
