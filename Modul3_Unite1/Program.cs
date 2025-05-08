using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_Unite3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 16, b = 12, c = 10;

            double islem1 = a + c / (double)(b - c) * 10;
            Console.WriteLine("Parantezli İşlem Sonucu: " + islem1);

            double islem2 = a + c / (double)b - c * 10;
            Console.WriteLine("Parantezsiz İşlem Sonucu: " + islem2);

            double islem3 = a + c * (b - c) / 10.0;
            Console.WriteLine("Çarpma ve Bölme Yer Değiştirilmiş Sonuç: " + islem3);

            Console.WriteLine("islem1 pozitif mi?: " + (islem1 > 0));

            bool sonucDogruMu = islem1 > islem2;
            Console.WriteLine("islem1 > islem2 mi?: " + sonucDogruMu);

            Console.ReadLine();
        }
    }
}

