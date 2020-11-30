using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    class ClassSom3
    {
        /// <summary>
        /// save and calculate all the point and create the colored pens
        /// </summary>
        public static FSom3 Form3;

        public static Pen PenRed = new Pen(Color.Red, 5);


        public static Point Point1;

        /// <summary>
        /// initialize the draw rectangle function and give colored
        /// pens based on which orientation the mouse was moved
        /// </summary>
        internal static void DrawRectangleWithColorOnOrientation(Control ctrl, Point p1, Point p2)
        {
            Pen p = new Pen(Color.Red, 2);
            Graphics g = ctrl.CreateGraphics();
            Point ul =new Point(0,0);
            if (p1.X > p2.X && p1.Y > p2.Y)
            {
                p.Color = Color.Red;
                ul = p2;
            }
            if (p1.X < p2.X && p1.Y < p2.Y)
            {
                p.Color = Color.Blue;
                ul = p1;
            }
            if (p1.X > p2.X && p1.Y < p2.Y)
            {
                p.Color = Color.Yellow;
                ul = new Point(p2.X, p1.Y);
            }
            if (p1.X < p2.X && p1.Y > p2.Y)
            {
                p.Color = Color.Green;
                ul = new Point(p1.X, p2.Y);
            }
            int w = p2.X - p1.X; if (w < 0) w = -w;
            int h = p2.Y - p1.Y; if (h < 0) h = -h;
            g.DrawRectangle(p, ul.X, ul.Y, w, h);
        }
                
    }
}

