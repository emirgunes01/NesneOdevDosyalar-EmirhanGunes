using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_Unite3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 123;
            object kutuluSayi = sayi; 
            Console.WriteLine("Boxing (kutulama) sonucu: " + kutuluSayi);

            int yeniSayi = (int)kutuluSayi; 
            Console.WriteLine("Unboxing (kutudan çıkarma) sonucu: " + yeniSayi);

            if (kutuluSayi is int)
            {
                Console.WriteLine("kutuluSayi değişkeni bir int türündedir.");
            }

            object metin = "Merhaba";
            string yazi = metin as string;

            if (yazi != null)
            {
                Console.WriteLine("as işlemi başarılı: " + yazi);
            }

            object sayisalMetin = 42;
            string donusum = sayisalMetin as string;
            if (donusum == null)
            {
                Console.WriteLine("as işlemi başarısız, donusum null döndü.");
            }

            Console.ReadLine();
        }
    }
}
