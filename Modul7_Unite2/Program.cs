using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7_Unite2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci birOgrenci = new Ogrenci();
            Ogretmen birOgretmen = new Ogretmen();

            birOgrenci.Buyu();
            birOgretmen.Buyu();

            birOgrenci.Oku();
            birOgretmen.Oku();

            Console.ReadLine();
        }
    }
}
