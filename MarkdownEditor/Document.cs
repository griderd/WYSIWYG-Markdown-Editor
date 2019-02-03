using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MSHTML;
using HtmlAgilityPack;
using System.IO;
using HtmlToMarkdown;
using HtmlToMarkdown.Editor.Tables;

namespace MarkdownEditor
{
    public class Document
    {
        public TabPage page, wysiwyg, codeView, htmlView;
        public TabControl viewTabs;
        public WebBrowser html;
        public TextBox code, htmlCode;

        public Guid ID { get; private set; }

        IHTMLDocument2 doc;
        IHTMLStyleSheet css;
        HtmlNode body;

        public bool Bold { get; private set; }
        public bool Italic { get; private set; }
        public bool Strike { get; private set; }
        public bool UnorderedList { get; private set; }
        public bool OrderedList { get; private set; }

        public Document(string name)
        {
            page = new TabPage("Untitled");
            viewTabs = new TabControl();
            viewTabs.Dock = DockStyle.Fill;
            page.Click += new EventHandler(page_Click);

            wysiwyg = new TabPage("WYSIWYG");
            html = new WebBrowser();
            html.Dock = DockStyle.Fill;
            wysiwyg.Controls.Add(html);
            viewTabs.TabPages.Add(wysiwyg);

            // Configure browser
            html.AllowNavigation = false;
            html.AllowWebBrowserDrop = false;
            html.IsWebBrowserContextMenuEnabled = false;
            html.ScriptErrorsSuppressed = true;
            html.DocumentText = "<html><body></body></html>";
            doc = html.Document.DomDocument as IHTMLDocument2;
            doc.designMode = "On";

            codeView = new TabPage("Markdown");
            code = new TextBox();
            code.Dock = DockStyle.Fill;
            code.Multiline = true;
            codeView.Controls.Add(code);
            viewTabs.TabPages.Add(codeView);
            code.Font = new System.Drawing.Font("Courier New", 10);
            code.ScrollBars = ScrollBars.Vertical;

            htmlView = new TabPage("HTML");
            htmlCode = new TextBox();
            htmlCode.Dock = DockStyle.Fill;
            htmlCode.Multiline = true;
            htmlView.Controls.Add(htmlCode);
            viewTabs.TabPages.Add(htmlView);
            htmlCode.Font = new System.Drawing.Font("Courier New", 10);
            htmlCode.ScrollBars = ScrollBars.Vertical;

            page.Controls.Add(viewTabs);

            ID = Guid.NewGuid();

            Bold = Italic = Strike = UnorderedList = OrderedList = false;
        }

        void page_Click(object sender, EventArgs e)
        {
            frmMain wnd = (frmMain)page.Parent.Parent.Parent.Parent;
            wnd.SelectDocument(ID);
        }

        public void LoadTemplate()
        {
            InsertHTML("<h1>Header</h1><p>Your text <strong>goes here</strong>.</p>");
        }

        public void InitializeStyleSheet()
        {
            css = doc.createStyleSheet("", 0);
            css.cssText = File.ReadAllText("github-markdown.css");
        }

        public void Update()
        {
            htmlCode.Text = html.DocumentText;

            HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(html.DocumentText);
            body = htmlDoc.DocumentNode.SelectSingleNode("//body");

            Converter converter = new Converter();
            code.Text = converter.Convert(body);
        }

        public void UpdateMarkdown()
        {
            code.Clear();

            StringBuilder sb = new StringBuilder();
            ParseNodes(sb);

            code.Text = sb.ToString();
        }

        public void ParseNodes(StringBuilder sb)
        {
            List<HtmlNode> nodes = new List<HtmlNode>();
            nodes.AddRange(body.Descendants(1));

            bool ignoreText = false;

            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i].NodeType == HtmlNodeType.Element)
                    ParseElement(nodes[i], sb, out ignoreText);
                else if ((!ignoreText) & (nodes[i].NodeType == HtmlNodeType.Text))
                    sb.Append(nodes[i].InnerText);
            }
        }

        public void ParseElement(HtmlNode node, StringBuilder sb, out bool ignoreText)
        {
            ignoreText = false;

            switch (node.Name)
            {
                case "h1":
                    sb.Append("# ");
                    break;

                case "h2":
                    sb.Append("## ");
                    break;

                case "h3":
                    sb.Append("### ");
                    break;

                case "h4":
                    sb.Append("#### ");
                    break;

                case "h5":
                    sb.Append("##### ");
                    break;

                case "h6":
                    sb.Append("###### ");
                    break;

                case "br":
                    sb.AppendLine("  ");
                    break;

                case "p":
                    sb.AppendLine();
                    break;
                    
                case "strong":
                    if (!sb.ToString().EndsWith(" "))
                        sb.Append(' ');
                    sb.Append("**");
                    // TODO: Parse nodes
                    sb.Append(node.InnerText);
                    sb.Append("**");
                    ignoreText = true;
                    break;

                case "em":
                    if (!sb.ToString().EndsWith(" "))
                        sb.Append(' ');
                    sb.Append("*");
                    // TODO: Parse nodes
                    sb.Append(node.InnerText);
                    sb.Append("*");
                    ignoreText = true;
                    break;

                case "strike":
                case "del":
                case "s":
                    if (!sb.ToString().EndsWith(" "))
                        sb.Append(' ');
                    sb.Append("~~");
                    // TODO: Parse nodes
                    sb.Append(node.InnerText);
                    sb.Append("~~");
                    ignoreText = true;
                    break;
            }
        }

        public void ParseDOM(IHTMLElement element, StringBuilder code)
        {
            IHTMLElementCollection childElements = element.children;

            for (int i = 0; i < childElements.length; i++)
            {
                IHTMLElement child = childElements.item(i);

                switch (child.tagName.ToLower())
                {
                    case "h1":
                        code.Append("# ");
                        code.AppendLine(child.innerText);
                        break;

                    case "p":
                        code.AppendLine(child.innerText);
                        break;
                }
            }
        }

        public void InsertHTML(string code)
        {
            IHTMLTxtRange range = doc.selection.createRange() as IHTMLTxtRange;
            range.pasteHTML(code);
            range.collapse(false);
            range.select();
        }

        public void ToggleBold()
        {
            doc.execCommand("Bold", false, null);
            
            // If no text is selected, flip the state ("None")
            // If text is actually highlighted, the type is "Text"
            if (doc.selection.type == "None")
                Bold = !Bold;
        }

        public void ToggleItalic()
        {
            doc.execCommand("Italic", false, null);
            if (doc.selection.type == "None")
                Italic = !Italic;
        }

        public void ToggleStrike()
        {
            doc.execCommand("Strikethrough", false, null);
            if (doc.selection.type == "None")
                Strike = !Strike;   
        }

        public void ToggleUnorderedList()
        {
            doc.execCommand("InsertUnorderedList", false, null);
            UnorderedList = !UnorderedList;
            OrderedList = false;
        }

        public void ToggleOrderedList()
        {
            doc.execCommand("InsertOrderedList", false, null);
            OrderedList = !OrderedList;
            UnorderedList = false;
        }

        public void InsertImage(string url, string alternateText)
        {
            InsertHTML(string.Format("<img src=\"{0}\" alt=\"{1}\" />", url, alternateText));
        }

        public void InsertTable(Table table)
        {
            InsertHTML(table.ToHtml());
        }

        public void InsertTable(int columns, int rows)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<table>");
            sb.Append("<thead>");

            sb.Append("<tr>");
            for (int j = 0; j < columns; j++)
            {
                sb.Append("<th></th>");
            }
            sb.Append("</tr>");
            sb.Append("</thead>");

            sb.Append("<tbody>");

            for (int i = 0; i < rows - 1; i++)
            {
                sb.Append("<tr>");
                for (int j = 0; j < columns; j++)
                {
                    sb.Append("<td></td>");
                }
                sb.Append("</tr>");
            }

            sb.Append("</tbody>");

            sb.Append("</table>");

            InsertHTML(sb.ToString());
        }

        public void Indent()
        {
            doc.execCommand("Indent");
        }

        public void Outdent()
        {
            doc.execCommand("Outdent");
        }

        public void WrapSelection(string tag)
        {
            IHTMLTxtRange range = doc.selection.createRange() as IHTMLTxtRange;
            range.pasteHTML(string.Format("<{0}>{1}</{0}>", tag, range.htmlText));
        }
    }
}
