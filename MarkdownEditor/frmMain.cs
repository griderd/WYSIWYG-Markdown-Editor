using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MarkdownEditor
{
    public partial class frmMain : Form
    {
        int currentDocument = 0;
        List<Guid> ids = new List<Guid>();
        List<Document> documents = new List<Document>();

        public Document CurrentDocument { get { return documents[currentDocument]; } }

        public frmMain()
        {
            InitializeComponent();
            textTypeList.SelectedIndex = 0;

            tvFiles.Nodes.Add("Root", "/", 0);
        }

        public void SelectDocument(Guid id)
        {
            for (int i = 0; i < ids.Count; i++)
            {
                if (ids[i] == id)
                    currentDocument = i;
            }
        }

        private void textTypeList_Click(object sender, EventArgs e)
        {

        }

        void NewDocument(string name)
        {
            Document doc = new Document(name);
            fileTabs.TabPages.Add(doc.page);
            documents.Add(doc);
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            foreach (Document doc in documents)
            {
                doc.Update();
                //tmrUpdate.Enabled = false;
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            CurrentDocument.ToggleBold();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            NewDocument("Untitled");
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            CurrentDocument.InitializeStyleSheet();
            CurrentDocument.LoadTemplate();
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            CurrentDocument.ToggleItalic();
        }

        private void btnStrikethrough_Click(object sender, EventArgs e)
        {
            CurrentDocument.ToggleStrike();
        }

        private void btnUnorderedList_Click(object sender, EventArgs e)
        {
            CurrentDocument.ToggleUnorderedList();
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInsertImage dlgInsertImage = new frmInsertImage();
            if (dlgInsertImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CurrentDocument.InsertImage(dlgInsertImage.txtSource.Text, dlgInsertImage.txtAltText.Text);
            }
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInsertTable dlgInsertTable = new frmInsertTable();
            if (dlgInsertTable.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CurrentDocument.InsertTable((int)dlgInsertTable.nudColumns.Value, (int)dlgInsertTable.nudRows.Value);
            }
        }
    }
}
