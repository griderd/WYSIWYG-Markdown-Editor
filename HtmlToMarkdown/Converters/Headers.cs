using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace HtmlToMarkdown.Converters
{
    class H1 : IConverter
    {
        public void Convert(HtmlNode node, Converter converter)
        {
            converter.result.Append("# ");
            converter.Parse(node);
            converter.result.AppendLine();
        }
    }

    class H2 : IConverter
    {
        public void Convert(HtmlNode node, Converter converter)
        {
            converter.result.Append("## ");
            converter.Parse(node);
            converter.result.AppendLine();
        }
    }

    class H3 : IConverter
    {
        public void Convert(HtmlNode node, Converter converter)
        {
            converter.result.Append("### ");
            converter.Parse(node);
            converter.result.AppendLine();
        }
    }

    class H4 : IConverter
    {
        public void Convert(HtmlNode node, Converter converter)
        {
            converter.result.Append("#### ");
            converter.Parse(node);
            converter.result.AppendLine();
        }
    }

    class H5 : IConverter
    {
        public void Convert(HtmlNode node, Converter converter)
        {
            converter.result.Append("##### ");
            converter.Parse(node);
            converter.result.AppendLine();
        }
    }

    class H6 : IConverter
    {
        public void Convert(HtmlNode node, Converter converter)
        {
            converter.result.Append("###### ");
            converter.Parse(node);
            converter.result.AppendLine();
        }
    }
}
