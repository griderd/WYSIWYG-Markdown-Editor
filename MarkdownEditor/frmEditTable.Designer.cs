namespace MarkdownEditor
{
    partial class frmEditTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAndExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitWithoutSavingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColumns = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRows = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.mnuColumns.SuspendLayout();
            this.mnuRows.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTable.Location = new System.Drawing.Point(0, 24);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTable.Size = new System.Drawing.Size(700, 436);
            this.dgvTable.TabIndex = 0;
            this.dgvTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTable_CellMouseClick);
            this.dgvTable.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTable_ColumnHeaderMouseClick);
            this.dgvTable.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTable_ColumnHeaderMouseDoubleClick);
            this.dgvTable.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTable_RowHeaderMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAndExitToolStripMenuItem,
            this.exitWithoutSavingToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // saveAndExitToolStripMenuItem
            // 
            this.saveAndExitToolStripMenuItem.Name = "saveAndExitToolStripMenuItem";
            this.saveAndExitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.saveAndExitToolStripMenuItem.Text = "Save and Exit";
            this.saveAndExitToolStripMenuItem.Click += new System.EventHandler(this.saveAndExitToolStripMenuItem_Click);
            // 
            // exitWithoutSavingToolStripMenuItem
            // 
            this.exitWithoutSavingToolStripMenuItem.Name = "exitWithoutSavingToolStripMenuItem";
            this.exitWithoutSavingToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exitWithoutSavingToolStripMenuItem.Text = "Exit without Saving";
            this.exitWithoutSavingToolStripMenuItem.Click += new System.EventHandler(this.exitWithoutSavingToolStripMenuItem_Click);
            // 
            // mnuColumns
            // 
            this.mnuColumns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.toolStripMenuItem1,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.mnuColumns.Name = "mnuColumns";
            this.mnuColumns.Size = new System.Drawing.Size(118, 98);
            this.mnuColumns.Opening += new System.ComponentModel.CancelEventHandler(this.mnuColumns_Opening);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(114, 6);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // mnuRows
            // 
            this.mnuRows.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.insertToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.deleteToolStripMenuItem1});
            this.mnuRows.Name = "mnuRows";
            this.mnuRows.Size = new System.Drawing.Size(108, 76);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // insertToolStripMenuItem1
            // 
            this.insertToolStripMenuItem1.Name = "insertToolStripMenuItem1";
            this.insertToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.insertToolStripMenuItem1.Text = "Insert";
            this.insertToolStripMenuItem1.Click += new System.EventHandler(this.insertToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(104, 6);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // frmEditTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 460);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "frmEditTable";
            this.Text = "Edit Table";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mnuColumns.ResumeLayout(false);
            this.mnuRows.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAndExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitWithoutSavingToolStripMenuItem;
        public System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.ContextMenuStrip mnuColumns;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip mnuRows;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
    }
}