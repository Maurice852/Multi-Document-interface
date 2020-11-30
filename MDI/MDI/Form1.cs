using System;
using System.Windows.Forms;

namespace MDI
{
    /// <summary>
    /// collection of basic exercices
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void som1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ClassSom1.Form1 == null)
            {
                ClassSom1.Form1 = new FSom1();
                ClassSom1.Form1.MdiParent = this;
            }
            ClassSom1.Form1.WindowState = FormWindowState.Maximized;
            ClassSom1.Form1.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void som2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ClassSom2.Form2 == null)
            {
                ClassSom2.Form2 = new FSom2();
                ClassSom2.Form2.MdiParent = this;
            }
            ClassSom2.Form2.WindowState = FormWindowState.Maximized;
            ClassSom2.Form2.Show();
        }

        private void som3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ClassSom3.Form3 == null)
            {
                ClassSom3.Form3 = new FSom3();
                ClassSom3.Form3.MdiParent = this;
            }
            ClassSom3.Form3.WindowState = FormWindowState.Maximized;
            ClassSom3.Form3.Show();
        }


    }
}
