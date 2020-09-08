using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Timer_Kulanımı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int sayac=0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            this.BackColor = Color.Green;
            button1.BackColor = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();

            if (sayac == 5)
            {
                this.BackColor = Color.Yellow;
                button1.BackColor = Color.Blue;
            }
            if (sayac == 10)
            {
                this.BackColor = Color.Green;
                sayac = 0;
                button1.BackColor = Color.Red;
            }
            
        }
    }
}
