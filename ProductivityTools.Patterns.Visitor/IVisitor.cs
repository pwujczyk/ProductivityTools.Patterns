using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.Visitor
{
    interface IVisitor
    {
        void Visit(PlainText docpart);
        void Visit(BoldText docpart);
    }
}
