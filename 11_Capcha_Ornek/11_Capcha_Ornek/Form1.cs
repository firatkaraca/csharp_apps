using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Capcha_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g", "q", "w", "z" };
            string[] sembol2 = { "A", "B", "C", "D", "E", "F", "G", "Q", "W", "Z" };
            string[] sembol3 = { "+", "-", "*", "/", "#", };
            string[] sembol4 = { "H", "ı", "J", "K", "L", "m", "n", "o", "P", "R", };

            Random rnd = new Random();
            int s1, s2, s3,s4,s5;
            s1 = rnd.Next(0,sembol1.Length);
            s2 = rnd.Next(0, sembol2.Length);
            s3 = rnd.Next(0, sembol3.Length);
            s4 = rnd.Next(0, 10);
            s5 = rnd.Next(0, sembol4.Length);
            label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + sembol3[s3].ToString() + s4.ToString() + sembol4[s5].ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == label1.Text) { 
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
            }
            else { MessageBox.Show("Hatalı Veri Girişi"); }


        }
    }
}
