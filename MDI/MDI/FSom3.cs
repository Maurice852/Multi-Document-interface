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
    public partial class FSom3 : Form
    {
        public FSom3()
        {
            InitializeComponent();
        }
        /// <summary>
        /// save the point at which the mouse button is released
        /// and draw a rectangle between the points.
        /// </summary>
        /// <algo>
        /// save the oposite cornors at which the mouse button is clicked and released and calculate the remaining
        /// corners by taking the X and Y coordinates and switching them.
        /// then check the direction in wich the mouse is dragged and change the color of the pen accordingly
        /// <algo>
        private void FSom3_MouseUp(object sender, MouseEventArgs e)
        {
            ClassSom3.DrawRectangleWithColorOnOrientation(this, ClassSom3.Point1, e.Location);
        }

        /// <summary>
        /// save mousedown location
        /// </summary>
        private void FSom3_MouseDown(object sender, MouseEventArgs e)
        {
            ClassSom3.Point1 = e.Location;
        }

        private void FSom3_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClassSom3.Form3 = null;
        }
    }
}
