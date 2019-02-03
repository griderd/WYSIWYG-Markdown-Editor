using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlToMarkdown.Editor.Tables
{
    public class Cell
    {
        public bool IsHeader { get; private set; }

        public string Content { get; set; }

        public Cell(string content, bool isHeader = false)
        {
            Content = content;
            IsHeader = isHeader;
        }

        public string ToHtml()
        {
            return string.Format("<{0}>{1}</{0}>", IsHeader ? "th" : "td", Content);

        }
    }
}
