using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_Unite2
{
    internal class Program
    {
        static void DegerArtir(ref int deger)
        {
            deger++;
        }
        static void Main(string[] args)
        {
            int sayi = 10;

            DegerArtir(ref sayi);

            Console.WriteLine("Sayı: " + sayi);
        }
       
    }
}   