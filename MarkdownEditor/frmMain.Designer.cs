namespace MarkdownEditor
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockQuotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.h1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.h2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.h3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.h4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.h5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.h6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.textTypeList = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBold = new System.Windows.Forms.ToolStripButton();
            this.btnItalic = new System.Windows.Forms.ToolStripButton();
            this.btnStrikethrough = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUnorderedList = new System.Windows.Forms.ToolStripButton();
            this.btnOrderedList = new System.Windows.Forms.ToolStripButton();
            this.btnIndent = new System.Windows.Forms.ToolStripButton();
            this.btnOutdent = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvFiles = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.fileTabs = new System.Windows.Forms.TabControl();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.insertToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1112, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.openDirectoryToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            // 
            // openDirectoryToolStripMenuItem
            // 
            this.openDirectoryToolStripMenuItem.Name = "openDirectoryToolStripMenuItem";
            this.openDirectoryToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.openDirectoryToolStripMenuItem.Text = "Open Directory...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveAllToolStripMenuItem.Text = "Save All";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(160, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(100, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.codeToolStripMenuItem,
            this.taskListToolStripMenuItem,
            this.blockQuotesToolStripMenuItem,
            this.linkToolStripMenuItem,
            this.headerToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.insertToolStripMenuItem.Text = "&Insert";
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.tableToolStripMenuItem.Text = "Table...";
            this.tableToolStripMenuItem.Click += new System.EventHandler(this.tableToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.imageToolStripMenuItem.Text = "Image...";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.codeToolStripMenuItem.Text = "Code...";
            this.codeToolStripMenuItem.Click += new System.EventHandler(this.codeToolStripMenuItem_Click);
            // 
            // taskListToolStripMenuItem
            // 
            this.taskListToolStripMenuItem.Name = "taskListToolStripMenuItem";
            this.taskListToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.taskListToolStripMenuItem.Text = "Task List...";
            // 
            // blockQuotesToolStripMenuItem
            // 
            this.blockQuotesToolStripMenuItem.Name = "blockQuotesToolStripMenuItem";
            this.blockQuotesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.blockQuotesToolStripMenuItem.Text = "Block Quotes...";
            this.blockQuotesToolStripMenuItem.Click += new System.EventHandler(this.blockQuotesToolStripMenuItem_Click);
            // 
            // linkToolStripMenuItem
            // 
            this.linkToolStripMenuItem.Name = "linkToolStripMenuItem";
            this.linkToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.linkToolStripMenuItem.Text = "Link...";
            this.linkToolStripMenuItem.Click += new System.EventHandler(this.linkToolStripMenuItem_Click);
            // 
            // headerToolStripMenuItem
            // 
            this.headerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.h1ToolStripMenuItem,
            this.h2ToolStripMenuItem,
            this.h3ToolStripMenuItem,
            this.h4ToolStripMenuItem,
            this.h5ToolStripMenuItem,
            this.h6ToolStripMenuItem});
            this.headerToolStripMenuItem.Name = "headerToolStripMenuItem";
            this.headerToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.headerToolStripMenuItem.Text = "Header";
            // 
            // h1ToolStripMenuItem
            // 
            this.h1ToolStripMenuItem.Name = "h1ToolStripMenuItem";
            this.h1ToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.h1ToolStripMenuItem.Text = "H1";
            // 
            // h2ToolStripMenuItem
            // 
            this.h2ToolStripMenuItem.Name = "h2ToolStripMenuItem";
            this.h2ToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.h2ToolStripMenuItem.Text = "H2";
            // 
            // h3ToolStripMenuItem
            // 
            this.h3ToolStripMenuItem.Name = "h3ToolStripMenuItem";
            this.h3ToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.h3ToolStripMenuItem.Text = "H3";
            // 
            // h4ToolStripMenuItem
            // 
            this.h4ToolStripMenuItem.Name = "h4ToolStripMenuItem";
            this.h4ToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.h4ToolStripMenuItem.Text = "H4";
            // 
            // h5ToolStripMenuItem
            // 
            this.h5ToolStripMenuItem.Name = "h5ToolStripMenuItem";
            this.h5ToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.h5ToolStripMenuItem.Text = "H5";
            // 
            // h6ToolStripMenuItem
            // 
            this.h6ToolStripMenuItem.Name = "h6ToolStripMenuItem";
            this.h6ToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.h6ToolStripMenuItem.Text = "H6";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textTypeList,
            this.toolStripSeparator2,
            this.btnBold,
            this.btnItalic,
            this.btnStrikethrough,
            this.toolStripSeparator1,
            this.toolStripSeparator3,
            this.btnUnorderedList,
            this.btnOrderedList,
            this.btnIndent,
            this.btnOutdent});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1112, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // textTypeList
            // 
            this.textTypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textTypeList.Items.AddRange(new object[] {
            "Normal",
            "Header 1",
            "Header 2",
            "Header 3",
            "Header 4",
            "Header 5",
            "Header 6",
            "Inline Code"});
            this.textTypeList.Name = "textTypeList";
            this.textTypeList.Size = new System.Drawing.Size(121, 25);
            this.textTypeList.Click += new System.EventHandler(this.textTypeList_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBold
            // 
            this.btnBold.CheckOnClick = true;
            this.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBold.Image = global::MarkdownEditor.Resource1.Bold;
            this.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(23, 22);
            this.btnBold.Text = "toolStripButton1";
            this.btnBold.ToolTipText = "Bold";
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.CheckOnClick = true;
            this.btnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItalic.Image = global::MarkdownEditor.Resource1.Italic;
            this.btnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(23, 22);
            this.btnItalic.Text = "toolStripButton2";
            this.btnItalic.ToolTipText = "Italic";
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnStrikethrough
            // 
            this.btnStrikethrough.CheckOnClick = true;
            this.btnStrikethrough.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStrikethrough.Image = global::MarkdownEditor.Resource1.Strikethrough;
            this.btnStrikethrough.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStrikethrough.Name = "btnStrikethrough";
            this.btnStrikethrough.Size = new System.Drawing.Size(23, 22);
            this.btnStrikethrough.Text = "toolStripButton2";
            this.btnStrikethrough.ToolTipText = "Strikethrough";
            this.btnStrikethrough.Click += new System.EventHandler(this.btnStrikethrough_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.CheckOnClick = true;
            this.toolStripSeparator1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSeparator1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSeparator1.Image")));
            this.toolStripSeparator1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(53, 22);
            this.toolStripSeparator1.Tag = "";
            this.toolStripSeparator1.Text = "<code>";
            this.toolStripSeparator1.ToolTipText = "Inline code";
            this.toolStripSeparator1.Click += new System.EventHandler(this.toolStripSeparator1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnUnorderedList
            // 
            this.btnUnorderedList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUnorderedList.Image = global::MarkdownEditor.Resource1.List_Bullets;
            this.btnUnorderedList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnorderedList.Name = "btnUnorderedList";
            this.btnUnorderedList.Size = new System.Drawing.Size(23, 22);
            this.btnUnorderedList.Text = "toolStripButton3";
            this.btnUnorderedList.ToolTipText = "Unordered list";
            this.btnUnorderedList.Click += new System.EventHandler(this.btnUnorderedList_Click);
            // 
            // btnOrderedList
            // 
            this.btnOrderedList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOrderedList.Image = global::MarkdownEditor.Resource1.List_Numbered;
            this.btnOrderedList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOrderedList.Name = "btnOrderedList";
            this.btnOrderedList.Size = new System.Drawing.Size(23, 22);
            this.btnOrderedList.Text = "toolStripButton4";
            this.btnOrderedList.ToolTipText = "Ordered list";
            // 
            // btnIndent
            // 
            this.btnIndent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIndent.Image = global::MarkdownEditor.Resource1.Indent;
            this.btnIndent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIndent.Name = "btnIndent";
            this.btnIndent.Size = new System.Drawing.Size(23, 22);
            this.btnIndent.Text = "toolStripButton1";
            this.btnIndent.Click += new System.EventHandler(this.btnIndent_Click);
            // 
            // btnOutdent
            // 
            this.btnOutdent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOutdent.Image = global::MarkdownEditor.Resource1.Outdent;
            this.btnOutdent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutdent.Name = "btnOutdent";
            this.btnOutdent.Size = new System.Drawing.Size(23, 22);
            this.btnOutdent.Text = "toolStripButton1";
            this.btnOutdent.Click += new System.EventHandler(this.btnOutdent_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvFiles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.fileTabs);
            this.splitContainer1.Size = new System.Drawing.Size(1112, 556);
            this.splitContainer1.SplitterDistance = 243;
            this.splitContainer1.TabIndex = 2;
            // 
            // tvFiles
            // 
            this.tvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFiles.ImageIndex = 0;
            this.tvFiles.ImageList = this.imageList1;
            this.tvFiles.Location = new System.Drawing.Point(0, 0);
            this.tvFiles.Name = "tvFiles";
            this.tvFiles.SelectedImageIndex = 0;
            this.tvFiles.Size = new System.Drawing.Size(243, 556);
            this.tvFiles.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folder_stuffed.ico");
            this.imageList1.Images.SetKeyName(1, "folder_open.ico");
            this.imageList1.Images.SetKeyName(2, "Generic_Document.ico");
            this.imageList1.Images.SetKeyName(3, "generic_picture.ico");
            this.imageList1.Images.SetKeyName(4, "zippedFile.ico");
            // 
            // fileTabs
            // 
            this.fileTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileTabs.Location = new System.Drawing.Point(0, 0);
            this.fileTabs.Name = "fileTabs";
            this.fileTabs.SelectedIndex = 0;
            this.fileTabs.Size = new System.Drawing.Size(865, 556);
            this.fileTabs.TabIndex = 0;
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 605);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Markdown Editor";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBold;
        private System.Windows.Forms.ToolStripButton btnItalic;
        private System.Windows.Forms.ToolStripButton btnStrikethrough;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox textTypeList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnUnorderedList;
        private System.Windows.Forms.ToolStripButton btnOrderedList;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockQuotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl fileTabs;
        private System.Windows.Forms.TreeView tvFiles;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.ToolStripMenuItem headerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem h1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem h2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem h3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem h4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem h5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem h6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnIndent;
        private System.Windows.Forms.ToolStripButton btnOutdent;
    }
}

