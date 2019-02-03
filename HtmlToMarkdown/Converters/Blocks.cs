using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace HtmlToMarkdown.Converters
{
    class p : IConverter
    {
        public void Convert(HtmlNode node, Converter converter)
        {
            converter.Parse(node);
        }
    }

    class div : IConverter
    {
        public void Convert(HtmlNode node, Converter converter)
        {
            converter.Parse(node);
        }
    }

    class br : IConverter
    {
        public void Convert(HtmlNode node, Converter converter)
        {
            converter.result.AppendLine("  ");
        }
    }
}
