using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3_Unite3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);
            int toplam = 0;

            for (int i = Math.Min(sayi1, sayi2); i <= Math.Max(sayi1, sayi2); i++)
            {
                toplam += i;
            }

            label4.Text = "Toplam (for): " + toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);
            int toplam = 0;

            int i = Math.Min(sayi1, sayi2);
            while (i <= Math.Max(sayi1, sayi2))
            {
                toplam += i;
                i++;
            }

            label4.Text = "Toplam (while): " + toplam.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);
            int toplam = 0;

            int i = Math.Min(sayi1, sayi2);
            do
            {
                toplam += i;
                i++;
            } while (i <= Math.Max(sayi1, sayi2));

            label4.Text = "Toplam (do): " + toplam.ToString();
        }
    }
}
