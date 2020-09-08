using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31_FormKenarlığı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //GraphicsPath gPath = new GraphicsPath();
            //Point[] pts = new Point[9];
            //pts[0] = new Point(142, 75);
            //pts[1] = new Point(227, 74);
            //pts[2] = new Point(258, 95);
            //pts[3] = new Point(338, 97);
            //pts[4] = new Point(337, 72);
            //pts[5] = new Point(379, 74);
            //pts[6] = new Point(382, 257);
            //pts[7] = new Point(147, 254);
            //pts[8] = new Point(143, 117);
            //gPath.AddPolygon(pts);
            //Region bolge = new Region(gPath);
            //this.Region = bolge;
            //this.BackColor = Color.FromArgb(147, 112, 219);

            GraphicsPath gpath = new GraphicsPath();
            Point[] pnt = new Point[8];
            pnt[0]= new Point(50, 50);
            pnt[1] = new Point(30, 100);
            pnt[2] = new Point(40, 200);
            pnt[3] = new Point(10, 300);
            pnt[4] = new Point(60, 800);
            pnt[5] = new Point(1600, 800);
            pnt[6] = new Point(1200,1200 );
            pnt[7] = new Point(1300, 0);
            
            

            gpath.AddPolygon(pnt);
            Region bolge = new Region(gpath);
            this.Region = bolge;

            this.BackColor = Color.Red;
        }
    }
}
