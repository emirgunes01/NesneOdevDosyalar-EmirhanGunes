﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Modul1_Unite2
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

        private void Topla_Click(object sender, RoutedEventArgs e)
        {
            int a = Int16.Parse(textBox1.Text);
            int b = Int16.Parse(textBox2.Text);
            textBox3.Text = (a + b).ToString();
        }

        private void Cikar_Click(object sender, RoutedEventArgs e)
        {
            int a = Int16.Parse(textBox1.Text);
            int b = Int16.Parse(textBox2.Text);
            textBox3.Text = (a - b).ToString();
        }

        private void Carp_Click(object sender, RoutedEventArgs e)
        {
            int a = Int16.Parse(textBox1.Text);
            int b = Int16.Parse(textBox2.Text);
            textBox3.Text = (a * b).ToString();
        }

        private void Bol_Click(object sender, RoutedEventArgs e)
        {
            int a = Int16.Parse(textBox1.Text);
            int b = Int16.Parse(textBox2.Text);
            textBox3.Text = (a / b).ToString();
        }
    }
}