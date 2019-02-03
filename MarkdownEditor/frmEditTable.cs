using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GSLib.Forms;
using HtmlToMarkdown.Editor.Tables;

namespace MarkdownEditor
{
    public partial class frmEditTable : Form
    {
        public Table Result { get; private set; }

        public frmEditTable()
        {
            InitializeComponent();
        }

        public frmEditTable(Table table) : this()
        {
            for (int i = 0; i < table.Columns; i++)
            {
                AddColumn(table.GetCell(0, i).Content);
            }

            AddRows(table.Rows.Length - 1);

            for (int row = 1; row < table.Rows.Length; row++)
            {
                for (int column = 0; column < table.Columns; column++)
                {
                    dgvTable.Rows[row - 1].Cells[column].Value = table.GetCell(row, column).Content;
                }
            }
        }

        private void addColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputBox header = new InputBox("Enter header name: ", "Header Name", "Column", '\0');
            if (header.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                AddColumn(header.Response);
            }
        }

        public DataGridViewColumn NewColumn(string name)
        {
            DataGridViewColumn column = new DataGridViewColumn();
            column.HeaderText = name;
            column.SortMode = DataGridViewColumnSortMode.NotSortable;
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            column.CellTemplate = cell;
            column.HeaderCell.ContextMenuStrip = mnuColumns;

            return column;
        }

        public void AddColumn(string name)
        {
            dgvTable.Columns.Add(NewColumn(name));
        }

        public void InsertColumn(string name, int index)
        {
            dgvTable.Columns.Insert(index, NewColumn(name));
        }
      
        public void AddRows(int count = 1)
        {
            for (int i = 0; i < count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.ContextMenuStrip = mnuRows;
                dgvTable.Rows.Add(row);
            }
        }

        public void InsertRow(int index)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.ContextMenuStrip = mnuRows;
            dgvTable.Rows.Insert(index, row);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvTable_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            InputBox cellName = new InputBox("Enter header name: ", "Header Name", dgvTable.Columns[e.ColumnIndex].HeaderText, '\0');

            if (cellName.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dgvTable.Columns[e.ColumnIndex].HeaderText = cellName.Response;
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddColumn("New Column");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTable.SelectedColumns.Count > 0)
            {
                dgvTable.Columns.RemoveAt(dgvTable.SelectedColumns[0].DisplayIndex);
            }
        }

        private void mnuColumns_Opening(object sender, CancelEventArgs e)
        {

        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertColumn("New Column", dgvTable.SelectedColumns[0].Index);
        }

        private void dgvTable_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvTable.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
            dgvTable.Columns[e.ColumnIndex].Selected = true;
        }

        private void insertToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dgvTable.SelectedColumns.Count > 0)
            {
                InsertColumn("New Column", dgvTable.SelectedColumns[0].Index);
            }
        }

        private void dgvTable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvTable.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            dgvTable.Rows[e.RowIndex].Selected = true;
        }

        private void dgvTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvTable.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvTable.ClearSelection();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddRows();
        }

        private void insertToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvTable.SelectedRows.Count > 0)
            {
                InsertRow(dgvTable.SelectedRows[0].Index);
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvTable.SelectedRows.Count > 0)
            {
                dgvTable.Rows.RemoveAt(dgvTable.SelectedRows[0].Index);
            }
        }

        private void saveAndExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Result = Table.FromDataGridView(dgvTable);
            this.Close();
        }

        private void exitWithoutSavingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
