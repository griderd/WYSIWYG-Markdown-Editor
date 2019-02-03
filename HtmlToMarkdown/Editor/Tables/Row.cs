using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlToMarkdown.Editor.Tables
{
    public class Row
    {
        public bool IsHeader { get; private set; }

        List<Cell> cells;

        public Cell[] Cells
        {
            get
            {
                return cells.ToArray();
            }
        }

        public Cell this[int index]
        {
            get
            {
                if ((index >= 0) & (index < cells.Count))
                    return cells[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if ((index >= 0) & (index < cells.Count))
                {
                    if (value != null)
                        cells[index] = value;
                    else
                        throw new NullReferenceException();
                }
                else
                    throw new IndexOutOfRangeException();
            }
        }

        public Row(int columns, bool isHeader = false)
        {
            IsHeader = isHeader;
            cells = new List<Cell>();

            for (int i = 0; i < columns; i++)
            {
                cells.Add(new Cell("", IsHeader));
            }
        }

        public string ToHtml()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<tr>");

            for (int i = 0; i < cells.Count; i++)
            {
                sb.Append(cells[i].ToHtml());
            }

            sb.Append("</tr>");

            return sb.ToString();
        }
    }
}
