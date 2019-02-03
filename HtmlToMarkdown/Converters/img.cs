using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlToMarkdown.Converters
{
    class img : IConverter
    {
        public void Convert(HtmlAgilityPack.HtmlNode node, Converter converter)
        {
            string url = node.Attributes["src"].Value;
            string alt = node.Attributes["alt"].Value;

            converter.result.AppendLine();
            converter.result.AppendFormat("![{0}]({1})", alt, url);
            converter.result.AppendLine();
        }
    }
}
