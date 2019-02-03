using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using HtmlToMarkdown.Converters;

namespace HtmlToMarkdown
{
    public class Converter
    {
        internal StringBuilder result = new StringBuilder();
        internal Stack<Flags> flags = new Stack<Flags>();

        internal Dictionary<string, IConverter> converters;

        public bool IgnoreNewLine { get; set; }

        public Converter()
        {
            converters = new Dictionary<string, IConverter>();

            converters.Add("h1", new H1());
            converters.Add("h2", new H2());
            converters.Add("h3", new H3());
            converters.Add("h4", new H4());
            converters.Add("h5", new H5());
            converters.Add("h6", new H6());
            converters.Add("p", new p());
            converters.Add("div", new div());
            converters.Add("br", new br());
            converters.Add("strong", new strong());
            converters.Add("em", new em());
            converters.Add("strike", new strike());
            converters.Add("ol", new ol());
            converters.Add("ul", new ul());
            converters.Add("li", new li());
            converters.Add("table", new table());
            converters.Add("thead", new thead());
            converters.Add("tbody", new tbody());
            converters.Add("tr", new tr());
            converters.Add("th", new th());
            converters.Add("td", new td());
        }

        public string Convert(HtmlNode node)
        {
            Parse(node);
            return result.ToString();
        }

        internal void Parse(HtmlNode node)
        {
            HtmlNode[] nodes = node.ChildNodes.ToArray();

            for (int i = 0; i < nodes.Length; i++)
            {
                HtmlNode child = nodes[i];

                if (child.NodeType == HtmlNodeType.Text)
                {
                    if ((child.InnerText.Trim() == "") & (child.InnerText.Contains("\r\n")) & (IgnoreNewLine))
                        continue;
                    result.Append(child.InnerText);
                }
                else
                {
                    ConvertNode(child);
                }
            }
        }

        void ConvertNode(HtmlNode node)
        {
            if (converters.ContainsKey(node.Name))
            {
                converters[node.Name].Convert(node, this);
            }
        }
    }
}
