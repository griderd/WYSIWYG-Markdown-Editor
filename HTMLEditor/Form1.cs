using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MSHTML;

namespace HTMLEditor
{
    public partial class Form1 : Form
    {
        IHTMLDocument2 doc;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HTMLEditor.DocumentText = "<html><body></body></html>";
            doc = HTMLEditor.Document.DomDocument as IHTMLDocument2;
            doc.designMode = "On";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = HTMLEditor.DocumentText;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = HTMLEditor.DocumentText;
        }

        private void btnHeader1_Click(object sender, EventArgs e)
        {
            IHTMLTxtRange range = doc.selection.createRange() as IHTMLTxtRange;
            range.pasteHTML("<h1>Header</h1>");
            range.collapse(false);
            range.select();
        }
    }
}
