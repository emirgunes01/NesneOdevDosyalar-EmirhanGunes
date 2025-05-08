using System;

namespace Modul7_Unite1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ogrenci birOgrenci = new Ogrenci("Ali UZUN");
            //Console.WriteLine("Öğrencimiz {0}'un Boyu {1}, kilosu ise {2}",
            //    birOgrenci.Ad, birOgrenci.Boy, birOgrenci.Kilo);


            Ogrenci birOgrenci = new Ogrenci("Ali UZUN");
            Console.WriteLine("Adı");
            Console.WriteLine("{0}", birOgrenci.Ad);
            Console.WriteLine("Boyu");
            Console.WriteLine("{0}", birOgrenci.Boy);
            Console.WriteLine("Kilosu");
            Console.WriteLine("{0}", birOgrenci.Kilo);
            Console.WriteLine("\n");

            Daire daire = new Daire(3.0);
            Console.WriteLine("Kürenin Alanı:");
            Console.WriteLine("{0}", daire.Alan());
        }
    }
}
