using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_Unite2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tarih bugun = new Tarih(7, 5, 2025);

            bugun.Yazdir();

            Console.ReadLine();
        }
        struct Tarih
        {
            public int gun;
            public int ay;
            public int yil;
            public Tarih(int g, int a, int y)
            {
                gun = g;
                ay = a;
                yil = y;
            }
            public void Yazdir()
            {
                Console.WriteLine($"Tarih: {gun}/{ay}/{yil}");
            }
        }  
    }
}

