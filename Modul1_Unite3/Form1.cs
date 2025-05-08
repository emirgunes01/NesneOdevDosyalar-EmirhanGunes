using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul1_Unite3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 30;
            textBox1.Text = i.ToString();

            //double i = 3.14;
            //textBox1.Text = i.ToString();

            //string i = "Merhaba";
            //textBox1.Text = i;


        }
    }
}
