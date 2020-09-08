using System;
using System.Drawing;
using System.Windows.Forms;

namespace _27_Dinamik_Araçlar2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            this.Font = new Font(this.Font.FontFamily, 9);
            this.BackColor = Color.LightBlue;
            this.Size = new Size(415, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            Button btn = new Button();
            Point btnkonum = new Point(125, 150);
            btn.Location = btnkonum;
            btn.Name = "Button1";
            btn.Text = "Hesapla";
            btn.Size = new Size(130, 40);
            this.Controls.Add(btn);
            btn.Font = new Font(btn.Font.FontFamily, 16);
            btn.BackColor = Color.Red;


            Label lbl = new Label();
            lbl.Location = new Point(275, 50);
            lbl.Name = "label1";
            lbl.Text = "Sonuç?";
            this.Controls.Add(lbl);
            lbl.Show();
            lbl.Font = new Font(lbl.Font.FontFamily, 16);


            for(int i = 1; i <= 2; i++)
            {
                TextBox txt = new TextBox();
                txt.Location = new Point(110, i * 50);
                txt.Name = "Textbox" + i;
                txt.Width = 160;
                this.Controls.Add(txt);
                txt.Font = new Font(txt.Font.FontFamily, 14);
            }

            btn.Click += button1;//Butona tıklama işlemi
      
        }

        int s1, s2,toplam;
        private void button1(object sender, EventArgs e)
        {
            foreach (Control txt in this.Controls)
            {
                if (txt.Name == "Textbox1")
                {
                    s1 = Convert.ToInt16(txt.Text);
                }
                if (txt.Name == "Textbox2")
                {
                    s2 = Convert.ToInt16(txt.Text);
                }
            }
            toplam = s1 + s2;
            
            foreach(Control lbl in this.Controls)
            {
                if (lbl.Name == "label1")
                {
                    lbl.Text = toplam.ToString();
                }
            }
        }

        //
    }
}
