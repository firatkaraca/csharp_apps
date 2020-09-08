using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_Point_Asansör_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            Point konum = new Point();
            if (sayac == 0)
            {
                konum.X = 55;
                konum.Y = 100;
                pictureBox1.Location = konum;
            }
            if (sayac == 10)
            {
                konum.X = 55;
                konum.Y = 111;
                pictureBox1.Location = konum;
                label4.Visible = false;
                label3.Visible = true;
            }
            if (sayac == 20)
            {
                konum.X = 55;
                konum.Y = 221;
                pictureBox1.Location = konum;
                label3.Visible = false;
                label2.Visible = true;
            }
            if (sayac == 30)
            {
                konum.X = 55;
                konum.Y = 325;
                pictureBox1.Location = konum;
                label2.Visible = false;
                label1.Visible = true;
                timer1.Stop();
                sayac = 0;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            timer1.Start();
        }
    }
}
