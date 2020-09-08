using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_TryCatch_Blogu
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ARAÇLARI KONUMLANDIRMA

            button1.Text = "Hesapla";
            label1.Text = "Sayı1:";
            label2.Text = "Sayı2:";
            textBox1.Width = 180;
            textBox2.Width = 180;
            button1.Width = 180;
            button1.Height = textBox1.Height;

            Point pnt = new Point();
            pnt.X = textBox1.Location.X;
            pnt.Y = (textBox2.Location.Y) + (textBox2.Location.Y - textBox1.Location.Y);
            button1.Location = pnt;

            Point lblkonum = new Point();
            lblkonum.X = textBox1.Location.X - label1.Width;
            lblkonum.Y = textBox1.Location.Y;
            label1.Location = lblkonum;

            Point lbl2 = new Point();
            lbl2.X = textBox2.Location.X - label2.Width;
            lbl2.Y = textBox2.Location.Y;
            label2.Location = lbl2;

            this.BackColor = Color.LightSeaGreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fr = new Form();
            Point frmkonum = new Point(5, 5);
            fr.Location = frmkonum;
            fr.Text = "Sanal Form";
            fr.Width = 700;
            fr.Height = 400;
            fr.Show();

            Label lbl = new Label();
            Point lblkonum = new Point(200, 170);
            lbl.Location = lblkonum;
            lbl.Name = "lblsanal";
            lbl.Text = "HESAP MAKİNESİ";
            lbl.ForeColor = Color.Red;
            lbl.AutoSize = true;
            fr.Controls.Add(lbl);

            lbl.Font = new Font(lbl.Font.FontFamily, 25);//FONT BÜYÜTME


            Button btn = new Button();
            Point btnkonum = new Point(67, 200);
            btn.Location = btnkonum;
            btn.Name = "btnsanal";
            btn.Text = "Hesapla";
            btn.BackColor = Color.Red;
            btn.Height = 40;
            btn.Width = 120;
            fr.Controls.Add(btn);
            btn.Font = new Font(btn.Font.FontFamily, 16);




            for (int i = 1; i <= 5; i++)
            {
                TextBox txt = new TextBox();
                Point txtkonum = new Point(50, i * 33);
                txt.Location = txtkonum;
                txt.Name = "Textbx" + i;
                txt.Text = i.ToString();
                txt.Width = 150;
                fr.Controls.Add(txt);
                txt.Font = new Font(txt.Font.FontFamily, 14);
            }

        }
    }
}
