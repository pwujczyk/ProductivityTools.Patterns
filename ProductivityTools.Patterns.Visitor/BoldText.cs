using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.Visitor
{
    class BoldText : DocumentPart
    {

        public BoldText(string text) : base(text) { }

        public override string ToHtml()
        {
            return $"<b>{Text}</b>";
        }

        public override string ToPlainText()
        {
            return Text;
        }
    }
}
