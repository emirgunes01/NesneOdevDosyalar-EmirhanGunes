using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3_Unite4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    throw new ArgumentNullException("Sayı alanı boş geçilemez.");
                }

                int sayi = int.Parse(textBox1.Text);

                if (sayi < 0)
                {
                    throw new Exception("Negatif sayıların faktöriyeli hesaplanamaz.");
                }

                long faktoriyel = checked(FaktoriyelHesapla(sayi));

                label2.Text = "Sonuç: " + faktoriyel.ToString();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen sadece tam sayı giriniz.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Sayı çok büyük! Faktöriyel hesaplamasında taşma oluştu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                textBox1.Clear();
                textBox1.Focus();
            }
        }
        private long FaktoriyelHesapla(int n)
        {
            long sonuc = 1;
            for (int i = 1; i <= n; i++)
            {
                sonuc *= i;
            }
            return sonuc;
        }
    }
}
