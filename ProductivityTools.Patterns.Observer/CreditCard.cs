using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.Observer
{
    class CreditCard
    {
        public delegate void Callback (decimal amount);

        public event Callback PaymentDone;

        public void Pay()
        {
            Console.WriteLine("Paying at ATM");
            this.PaymentDone(12);
        }
    }
}
