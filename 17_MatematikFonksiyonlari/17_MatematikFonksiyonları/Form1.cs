using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_MatematikFonksiyonları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            //label2.Text = Math.Abs(sayi).ToString();
            //label2.Text = Math.Ceiling(sayi).ToString();
            //label2.Text = Math.Floor(sayi).ToString();
            //label2.text = math.pow(sayi, 3).tostring();
            label2.Text = Math.Sqrt(sayi).ToString();
        }
    }
}
/* 
 Abs=Mutlak Değer
 Ceil=Üste Yuvarlama ----Tavan
 Floor=Alta yuvarlama ---Taban
 Pow=Üs Alma >>> (5,3)=125
 sqrt=Karekök >>>(9)=3


*/