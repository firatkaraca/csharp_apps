using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_MessageBoxParametreli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgileriniz Başarıyla Kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                Application.Exit();
            }
            else
            {
                DialogResult cikis = new DialogResult();
                cikis = MessageBox.Show("Kaydetmeden çıkmak istediğinize emin misiniz?", "Dikkat?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cikis == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
    }
}
