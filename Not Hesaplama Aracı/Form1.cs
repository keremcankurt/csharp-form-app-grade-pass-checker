using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_Hesaplama_Aracı
{
    public partial class Form1 : Form
    {
        public static void SayiKontrol(TextBox tBox)
        {
            tBox.BackColor = Color.White;

            string text;
            text = tBox.Text;
            bool kontrol = true;
            // harf girmesi engellendi
            for (int i = 0; i < tBox.TextLength; i++)
            {

                if (!Char.IsNumber(text[i]))
                {
                    kontrol = false;
                    break;
                }
            }
            //harf varsa 0a eşitlendi
            if (!kontrol) tBox.Text = "0";
            //boşsa 0
            if (tBox.Text == "")
            {
                tBox.Text = "0";
            }
            //0dan küçükse 0
            else if (Convert.ToInt32(tBox.Text) < 0)
            {
                tBox.Text = "0";
            }
            //100den büyükse 100
            else if (Convert.ToInt32(tBox.Text) > 100)
            {
                tBox.Text = "100";
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SayiKontrol(textBox1 as TextBox);
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "";
            textBox7.Text = "";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SayiKontrol(textBox2 as TextBox);
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            SayiKontrol(textBox3 as TextBox);
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            SayiKontrol(textBox4 as TextBox);
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            SayiKontrol(textBox5 as TextBox);
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam;
            int vize;
            int vizeOran;
            int final;
            int finalOran;
            int minGecmeNotu;
            double ortalama;
            toplam = Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text);
            if (toplam != 100)
            {
                textBox2.BackColor = Color.Red;
                textBox3.BackColor = Color.Red;
                MessageBox.Show("Vize ve Final katkı oranları toplamı 100 olmalıdır.");

            }
            else
            {
                vize = Convert.ToInt32(textBox4.Text);
                vizeOran = Convert.ToInt32(textBox2.Text);
                final = Convert.ToInt32(textBox5.Text);
                finalOran = Convert.ToInt32(textBox3.Text);
                minGecmeNotu = Convert.ToInt32(textBox1.Text);
                ortalama = (vize * vizeOran / 100.0) + (final * finalOran / 100.0);
                textBox6.Text = ortalama.ToString();
                if (ortalama >= minGecmeNotu)
                {
                    textBox7.Text = "Geçer";
                }
                else
                {
                    textBox7.Text = "Kalır";
                }
            }
        }
    }
}
