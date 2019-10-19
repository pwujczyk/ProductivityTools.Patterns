using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.Observer
{
    class AmlObserver
    {
        CreditCard card;

        public AmlObserver(CreditCard card)
        {
            this.card = card;
            this.card.PaymentDone += Card_PaymentDone;
        }

        private void Card_PaymentDone(decimal amount)
        {
            Console.WriteLine("Anti-Money Laundering check");
        }
    }
}
