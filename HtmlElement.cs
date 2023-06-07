using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleHtmlBuilderCSharp
{
    public class HtmlElement
    {
        private readonly string _tag;
        private readonly string _text;

        public HtmlElement(string tag, string text)
        {
            _tag = tag;
            _text = text;
        }

        public override string ToString()
        {
            return $"<{_tag}>{_text}</{_tag}>";
        }
    }
}