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
            converter.IgnoreNewLine = true;
            converter.Parse(node);
            converter.IgnoreNewLine = false;
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

            Flags[] flags = converter.flags.ToArray();
            int count = -1;
            for (int i = 0; i < flags.Length; i++)
            {
                if ((flags[i] == Flags.OrderedList) | (flags[i] == Flags.UnorderedList))
                    count += 1;
            }

            string spaces = new string(' ', count * 2);
            converter.result.Append(spaces);

            Flags flag = converter.flags.Peek();
            if (flag == Flags.UnorderedList)
                converter.result.Append("* ");
            else
                converter.result.Append("1. ");

            converter.Parse(node);
            converter.result.AppendLine();
        }
    }
}
