using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Modul6_Unite1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            islem();

        }
        public void islem()
        {
            try
            {
                int sayi1 = int.Parse(TextBox1.Text);
                int sayi2 = int.Parse(TextBox2.Text);
                int toplam = sayi1 + sayi2;
                TextBox3.Text = toplam.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz.");
            }
        }
    }
}