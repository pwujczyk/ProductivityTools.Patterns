using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Patterns.Visitor
{
    class Document
    {
        private List<DocumentPart> documentParts = new List<DocumentPart>();

        public void Add(DocumentPart documentPart)
        {
            this.documentParts.Add(documentPart);
        }

        public string ToHtml()
        {
            var s = string.Empty;
            foreach (var item in documentParts)
            {
                s += item.ToHtml();
            }
            return s;
        }

        public string ToPlainText()
        {
            var s = string.Empty;
            foreach (var item in documentParts)
            {
                s += item.ToPlainText()+ " ";
            }
            return s;
        }
    }
}
