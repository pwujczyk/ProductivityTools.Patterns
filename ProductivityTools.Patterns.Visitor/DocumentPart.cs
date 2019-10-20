using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.Visitor
{
    abstract class DocumentPart
    {
        public string Text { get; private set; }

        public DocumentPart(string text)
        {
            this.Text = text;
        }

        //public abstract string ToPlainText();
        //public abstract string ToHtml();
        public abstract void Accept(IVisitor visitor);
    }
}
