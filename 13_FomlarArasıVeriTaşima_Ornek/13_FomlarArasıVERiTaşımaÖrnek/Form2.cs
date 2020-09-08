using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_FomlarArasıVERiTaşımaÖrnek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string isim;
        public string soyisim;
        public string tc;
        public string numara;
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Text = isim+ "\n" + soyisim + "\n" + tc + "\n" + numara;

            label1.Text = isim.ToUpper();
            label2.Text = soyisim.ToUpper();
            label3.Text = tc;
            label4.Text = numara;

            label9.Text = "Hoşgeldiniz sayın " + isim + " " + soyisim + ":-)";
;        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fk = new Form1();
            fk.Show();
            this.Hide();
        }
    }
}
