using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9_Unite1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayi = { 1, 2, 3, 4 };

            int toplam = 0;

            foreach (int i in sayi)
            {
                toplam = toplam + i;
            }
            Console.WriteLine("Dizi elemanlarının toplamı: " + toplam);
        }
    }
}
