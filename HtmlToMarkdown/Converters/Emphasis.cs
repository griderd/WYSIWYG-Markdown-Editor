using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlToMarkdown.Converters
{
    class strong : IConverter
    {
        public void Convert(HtmlAgilityPack.HtmlNode node, Converter converter)
        {
            converter.result.Append("**");
            converter.Parse(node);
            converter.result.Append("**");
        }
    }

    class em : IConverter
    {
        public void Convert(HtmlAgilityPack.HtmlNode node, Converter converter)
        {
            converter.result.Append("*");
            converter.Parse(node);
            converter.result.Append("*");
        }
    }

    class strike : IConverter
    {
        public void Convert(HtmlAgilityPack.HtmlNode node, Converter converter)
        {
            converter.result.Append("~~");
            converter.Parse(node);
            converter.result.Append("~~");
        }
    }
}
