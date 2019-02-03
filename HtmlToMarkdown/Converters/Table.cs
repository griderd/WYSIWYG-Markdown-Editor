using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlToMarkdown.Converters
{
    class table : IConverter
    {
        public void Convert(HtmlAgilityPack.HtmlNode node, Converter converter)
        {
            converter.flags.Push(Flags.Table);
            converter.IgnoreNewLine = true;
            converter.Parse(node);
            converter.flags.Pop();
            converter.IgnoreNewLine = false;
        }
    }

    class thead : IConverter
    {
        public void Convert(HtmlAgilityPack.HtmlNode node, Converter converter)
        {
            if (converter.flags.Peek() == Flags.Table)
            {
                converter.flags.Push(Flags.TableHead);
                converter.Parse(node);
                converter.flags.Pop();

                int count = ((th)converter.converters["th"]).Count;

                for (int i = 0; i < count; i++)
                {
                    converter.result.Append("|-");
                }
                converter.result.AppendLine("|");
            }
            else
            {
                //throw new FormatException();
            }
        }
    }

    class tbody : IConverter
    {
        public void Convert(HtmlAgilityPack.HtmlNode node, Converter converter)
        {
            if (converter.flags.Peek() == Flags.Table)
            {
                converter.flags.Push(Flags.TableBody);
                converter.Parse(node);
                converter.flags.Pop();
            }
            else
            {
                //throw new FormatException();
            }
        }
    }

    class tr : IConverter
    {
        public void Convert(HtmlAgilityPack.HtmlNode node, Converter converter)
        {
            Flags flag = converter.flags.Peek();
            if ((flag == Flags.TableHead) || (flag == Flags.TableBody))
            {
                converter.flags.Push(Flags.TableRow);
                converter.Parse(node);
                converter.flags.Pop();
                converter.result.AppendLine(" |");
            }
            else
            {
                //throw new FormatException();
            }
        }
    }

    class th : IConverter
    {
        public int Count { get; private set; }

        public th()
        {
            Count = 0;
        }

        public void Reset()
        {
            Count = 0;
        }

        public void Convert(HtmlAgilityPack.HtmlNode node, Converter converter)
        {
            if (converter.flags.Peek() == Flags.TableRow)
            {
                converter.result.Append("| ");
                converter.Parse(node);
                Count++;
            }
        }
    }

    class td : IConverter
    {
        public void Convert(HtmlAgilityPack.HtmlNode node, Converter converter)
        {
            if (converter.flags.Peek() == Flags.TableRow)
            {
                converter.result.Append("| ");
                converter.Parse(node);
            }
        }
    }
}
