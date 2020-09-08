using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _21_Metin_Belgesi_Oluşturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String DosyaAdi, DosyaYolu;
        StreamWriter sw;
        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DosyaYolu = folderBrowserDialog1.SelectedPath.ToString();
                textBox1.Text = DosyaYolu;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DosyaAdi = textBox2.Text;
            sw = File.CreateText(DosyaYolu + "\\" + DosyaAdi+".txt");
            sw.Close();
        }
    }
}
