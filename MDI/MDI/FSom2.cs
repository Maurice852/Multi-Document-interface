using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    /// <summary>
    /// copy input to output letter by letter by letter
    /// while increasing in fontsize
    /// </summary>
    public partial class FSom2 : Form
    {
        public FSom2()
        {
            InitializeComponent();
            timer1.Stop();

        }
        /// <summary>
        /// clear the output, reset the text size and start the timer
        /// </summary>
        private void btn1_Click(object sender, EventArgs e)
        {
            ClassSom2.a = 0;
            txtOutput.Clear();
            ClassSom2.txtSize = 10;
            timer1.Start();
        }

        /// <summary>
        /// increase the text size every timer tick
        /// and add one extra letter from the input to the output
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ClassSom2.a  < txtInput.Text.Length)
            {
                ClassSom2.txtSize++;
                txtOutput.Font = new Font("Arial", ClassSom2.txtSize, FontStyle.Bold);
                txtOutput.Text += txtInput.Text[ClassSom2.a];
                ClassSom2.a++;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void FSom2_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClassSom2.Form2 = null;
        }
    }
}
