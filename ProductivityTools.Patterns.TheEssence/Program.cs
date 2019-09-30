using System;

namespace ProductivityTools.Patterns.TheEssence
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact.ContactEssence essence = new Contact.ContactEssence();

            // Cannot create Contact yet ...
            Contact invalidContact = essence.CreateContact();
            if (invalidContact == null)
            {
                Console.WriteLine("Created NULL contact!");
            }

            // Fill in the rest of the required fields
            essence.FirstName = "Dermot";
            essence.LastName = "Gubbins";

            // Try creating contact again
            Contact validContact = essence.CreateContact();
            // Add a phone number (optional)
            // but not an address.
            validContact.PhoneNumber = "(+44) 444 444";

            // Display the valid contact.
            Console.WriteLine("\nContact Created ...\n");
            Console.WriteLine(validContact.ToString());

            Console.WriteLine("Press RETURN to end");
            Console.ReadLine();
        }
    }
}
