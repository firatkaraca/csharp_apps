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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.isim = textBox1.Text;
            frm.soyisim = textBox2.Text;
            frm.tc = maskedTextBox1.Text;
            frm.numara = maskedTextBox2.Text;
            frm.Show();
            this.Hide();

            
        }
    }
}
