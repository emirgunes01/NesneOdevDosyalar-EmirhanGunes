using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul8_Unite1
{
    internal class Program
    {
        public delegate void SiralamaDelegate(ref string[] kelimeler);

        static void Main(string[] args)
        {
            string[] kelimeler = { "elma", "armut", "üzüm", "muz", "kivi" };

            Console.WriteLine("Orijinal dizi:");
            foreach (var item in kelimeler)
                Console.WriteLine(item);

            SiralamaDelegate siralama = SiralamaIslemleri.AZSirala;

            Console.WriteLine("\n--- Tekli Çağrım: A-Z ---");
            siralama(ref kelimeler);

            siralama += SiralamaIslemleri.ZASirala;
            siralama += SiralamaIslemleri.BuyukHarfYap;

            Console.WriteLine("\n--- Çoklu Çağrım ---");
            siralama(ref kelimeler);

            Console.ReadLine();
        }
        public class SiralamaIslemleri
        {
            public static void AZSirala(ref string[] dizi)
            {
                Array.Sort(dizi);
                Console.WriteLine("A-Z sıralı:");
                foreach (var item in dizi)
                    Console.WriteLine(item);
            }
            public static void ZASirala(ref string[] dizi)
            {
                Array.Sort(dizi);
                Array.Reverse(dizi);
                Console.WriteLine("Z-A sıralı:");
                foreach (var item in dizi)
                    Console.WriteLine(item);
            }
            public static void BuyukHarfYap(ref string[] dizi)
            {
                for (int i = 0; i < dizi.Length; i++)
                    dizi[i] = dizi[i].ToUpper();
                Console.WriteLine("Büyük harfe çevrildi:");
                foreach (var item in dizi)
                    Console.WriteLine(item);
            }
        }
    }
}
