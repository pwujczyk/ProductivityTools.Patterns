using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.Visitor
{
    class PlainText : DocumentPart
    {
        public PlainText(string text) : base(text) { }

        //public override string ToHtml()
        //{
        //    return Text;
        //}

        //public override string ToPlainText()
        //{
        //    return Text;
        //}

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
