using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double girilenSayi1;
        double girilenSayi2;
        double sonuc;
        string islem; 
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "3";
        }

        private void button11_Click(object sender, EventArgs e)//4
        {
                textBox1.Text = textBox1.Text + "4";
        }

        private void button12_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "5";
        }

        private void button13_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "6";
        }

        private void button14_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "7";
        }

        private void button15_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "8";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " ")
            {
                textBox1.Text = "9";
            }
            else
                textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e) // 0 butonu
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text += "";
            }
            else
                textBox1.Text = textBox1.Text + "0";
        }

        private void button18_Click(object sender, EventArgs e) // , (virgül) butonu
        {
            if ((textBox1.Text == "") | (textBox1.Text.EndsWith(",")))  //textbox metni virgül ile bitiyor veya boşsa
            {
                textBox1.Text += "";    //bir şey yapma
            }
            else
            {
                textBox1.Text += ",";   //aksi halde virgül koy
            }
        }

        private void button9_Click(object sender, EventArgs e)  //C(sil) butonu
        {
            textBox1.ResetText();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string degisken = textBox1.Text.Substring(0, (textBox1.Text.Length - 1));
            textBox1.Text = degisken;

        }

        private void button5_Click(object sender, EventArgs e)  //-(eksi) butonu
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            else
            {
                girilenSayi1 = Convert.ToDouble(textBox1.Text); //ilk girilen sayi değişkenini sayi1'e atıyoruz
                textBox1.Text = ""; //sonra textBox'ı sıfırlıyoruz
                islem = "eksi";
            }
        }


        private void button7_Click(object sender, EventArgs e)  // bölü(/) butonu
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            else
            {
                girilenSayi1 = Convert.ToDouble(textBox1.Text); //ilk girilen sayi değişkenini sayi1'e atıyoruz
                textBox1.Text = ""; //sonra textBox'ı sıfırlıyoruz
                islem = "bolu";
            }
        }

        private void button8_Click(object sender, EventArgs e)  // = (esittir) butonu
        {
            girilenSayi2 = Convert.ToDouble(textBox1.Text);
            switch(islem)
            {
                case "eksi":
                    sonuc = girilenSayi1 - girilenSayi2;
                    textBox1.Text = sonuc.ToString();
                    break;
                case "bolu":
                    sonuc = girilenSayi1 / girilenSayi2;
                    textBox1.Text = sonuc.ToString();
                    break;
            }   
        }
    }
}
