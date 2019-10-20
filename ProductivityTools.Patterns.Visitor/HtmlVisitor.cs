using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.Visitor
{
    class HtmlVisitor : IVisitor
    {
        public string Output { get; private set; }

        public void Visit(PlainText docpart)
        {
            this.Output += docpart.Text;
        }

        public void Visit(BoldText docpart)
        {
            this.Output += $"<b>{docpart.Text}</b>";
        }
    }
}
