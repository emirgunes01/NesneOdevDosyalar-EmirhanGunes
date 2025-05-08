using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3_Unite2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int kat;
            bool basarili = int.TryParse(textBox1.Text, out kat);

            if (!basarili)
            {
                listBox1.Items.Add("Lütfen geçerli bir sayı giriniz.");
                return;
            }

            if (kat == 0)
            {
                listBox1.Items.Add("Zemin Kat: Danışma");
                listBox1.Items.Add("Zemin Kat: Güvenlik");
                listBox1.Items.Add("Zemin Kat: Bekleme Salonu");
            }
            else if (kat == 1)
            {
                listBox1.Items.Add("1. Kat: Müdür Odası");
                listBox1.Items.Add("1. Kat: Öğretmenler Odası");
                listBox1.Items.Add("1. Kat: Rehberlik Servisi");
            }
            else if (kat == 2)
            {
                listBox1.Items.Add("2. Kat: Laboratuvarlar");
                listBox1.Items.Add("2. Kat: Bilgisayar Sınıfı");
            }
            else if (kat == 3)
            {
                listBox1.Items.Add("3. Kat: Kütüphane");
                listBox1.Items.Add("3. Kat: Konferans Salonu");
            }
            else
            {
                listBox1.Items.Add("Lütfen 0-3 arasında bir kat numarası giriniz...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int kat;
            bool basarili = int.TryParse(textBox1.Text, out kat);

            if (!basarili)
            {
                listBox1.Items.Add("Lütfen geçerli bir sayı giriniz.");
                return;
            }

            switch (kat)
            {
                case 0:
                    listBox1.Items.Add("Zemin Kat: Danışma");
                    listBox1.Items.Add("Zemin Kat: Güvenlik");
                    listBox1.Items.Add("Zemin Kat: Bekleme Salonu");
                    break;
                case 1:
                    listBox1.Items.Add("1. Kat: Müdür Odası");
                    listBox1.Items.Add("1. Kat: Öğretmenler Odası");
                    listBox1.Items.Add("1. Kat: Rehberlik Servisi");
                    break;
                case 2:
                    listBox1.Items.Add("2. Kat: Laboratuvarlar");
                    listBox1.Items.Add("2. Kat: Bilgisayar Sınıfı");
                    break;
                case 3:
                    listBox1.Items.Add("3. Kat: Kütüphane");
                    listBox1.Items.Add("3. Kat: Konferans Salonu");
                    break;
                default:
                    listBox1.Items.Add("Lütfen 0-3 arasında bir kat numarası giriniz...");
                    break;
            }
        }
    }
}
