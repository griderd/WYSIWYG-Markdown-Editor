using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace HtmlToMarkdown.Converters
{
    interface IConverter
    {
        void Convert(HtmlNode node, Converter converter);
    }
}
