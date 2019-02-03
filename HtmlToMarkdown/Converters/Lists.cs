using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlToMarkdown.Converters
{
    class ol : IConverter
    {
        public void Convert(HtmlAgilityPack.HtmlNode node, Converter converter)
        {
            converter.flags.Push(Flags.OrderedList);
            converter.Parse(node);
            converter.flags.Pop();
        }
    }

    class ul : IConverter
    {
        public void Convert(HtmlAgilityPack.HtmlNode node, Converter converter)
        {
            converter.flags.Push(Flags.UnorderedList);
            converter.Parse(node);
            converter.flags.Pop();
        }
    }

    class li : IConverter
    {
        public void Convert(HtmlAgilityPack.HtmlNode node, Converter converter)
        {
            if (converter.flags.Count > 1)
                converter.result.Append(new string(' ', (converter.flags.Count - 1) * 2));

            Flags flag = converter.flags.Peek();
            if (flag == Flags.UnorderedList)
                converter.result.Append("* ");
            else
                converter.result.Append("1. ");

            converter.Parse(node);
        }
    }
}
