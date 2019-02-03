using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HtmlToMarkdown.Editor.Tables
{
    public class Table
    {
        List<Row> rows;

        public int Columns { get; private set; }

        public Row[] Rows
        {
            get
            {
                return rows.ToArray();
            }
        }

        public Row this[int index]
        {
            get
            {
                if ((index >= 0) & (index < rows.Count))
                {
                    return rows[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if ((index >= 0) & (index < rows.Count))
                {
                    if (value != null)
                    {
                        rows[index] = value;
                    }
                    else
                    {
                        throw new NullReferenceException();
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public Table(int columns, int rows)
        {
            this.rows = new List<Row>();
            Columns = columns;

            for (int i = 0; i < rows; i++)
            {
                this.rows.Add(new Row(columns, i == 0));
            }

            for (int i = 0; i < columns; i++)
            {
                this[0].Cells[i].Content = string.Format("Column {0}", i + 1);
            }
        }

        public string ToHtml()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<table><thead>");
            sb.Append(rows[0].ToHtml());
            sb.Append("</thead><tbody>");

            for (int i = 1; i < rows.Count; i++)
            {
                sb.Append(rows[i].ToHtml());
            }

            sb.Append("</tbody></table>");

            return sb.ToString();
        }

        public Cell GetCell(int row, int column)
        {
            return this[row][column];
        }

        public static Table FromDataGridView(DataGridView data)
        {
            Table table = new Table(data.Columns.Count, data.Rows.Count + 1);

            for (int i = 0; i < table.Columns; i++)
            {
                table.GetCell(0, i).Content = (string)data.Columns[i].HeaderCell.Value;
            }

            for (int row = 0; row < data.Rows.Count; row++)
            {
                for (int column = 0; column < data.Columns.Count; column++)
                {
                    table.GetCell(row + 1, column).Content = (string)data.Rows[row].Cells[column].EditedFormattedValue;
                }
            }

            return table;
        }
    }
}
