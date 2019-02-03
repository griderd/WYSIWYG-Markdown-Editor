using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HtmlToMarkdown.Editor.Tables;

namespace MarkdownEditor
{
    public partial class frmInsertTable : Form
    {
        public Table storedTable;

        public frmInsertTable()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            if (storedTable == null)
                storedTable = new Table((int)nudColumns.Value, (int)nudRows.Value);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            
        }

        private void frmInsertTable_Load(object sender, EventArgs e)
        {

        }

        private void editTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            storedTable = new Table((int)nudColumns.Value, (int)nudRows.Value);

            frmEditTable table = new frmEditTable(storedTable);

            if (table.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                storedTable = table.Result;
                DialogResult = System.Windows.Forms.DialogResult.None;

                nudColumns.Value = storedTable.Columns;
                nudRows.Value = storedTable.Rows.Length;
            }
        }
    }
}
