using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        int islem = 0;
        double onceki = 0 , sonraki = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void BtnBir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "1";
        }

        private void Btnİki_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "2";
        }

        private void BtnUc_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "3";
        }

        private void BtnDort_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "4";
        }

        private void BtnBes_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "5";
        }

        private void BtnAlti_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "6";
        }

        private void BtnYedi_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "7";
        }

        private void BtnSekiz_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "8";
        }

        private void BtnDokuz_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "9";
        }

        private void BtnSifir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "0";
        }

        private void BtnSifirla_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void BtnTopla_Click(object sender, EventArgs e)
        {
            islem = 1;
            onceki = Convert.ToInt32(textBox1.Text);           
            Temizle();
        }

        private void BtnCikar_Click(object sender, EventArgs e)
        {
            islem = 2;
            onceki = Convert.ToInt32(textBox1.Text);
            Temizle();
        }

        private void BtnCarp_Click(object sender, EventArgs e)
        {
            islem = 3;
            onceki = Convert.ToInt32(textBox1.Text);
            Temizle();
        }

        private void BtnBol_Click(object sender, EventArgs e)
        {
            islem = 4;
            onceki = Convert.ToInt32(textBox1.Text);
            Temizle();
        }
        public void Temizle()
        {
            textBox1.Clear();
        }
        public double Hesapla()
        {
            double sonuc = 0;
            if (islem ==1)
            {
                sonuc = onceki + sonraki;
            }
            else if (islem == 2)
            {
                sonuc = onceki - sonraki;
            }
            else if (islem == 3)
            {
                sonuc = onceki * sonraki;
            }
            else if (islem == 4)
            {
                sonuc = onceki / sonraki;
            }
            else
            {
                sonuc = 0;
            }

            return sonuc;
        }      

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            sonraki = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Hesapla().ToString("#,#.00");
        }
    }
}
