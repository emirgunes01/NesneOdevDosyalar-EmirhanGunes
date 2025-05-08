using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5_Unite1
{
    internal class Program

    {
        class Bisiklet
        {
            private int hiz;
            private int vites;
            private int VitesSayisi;

            public Bisiklet()
            {
                vites = 1;
                hiz = 0;
                VitesSayisi = 18;
            }

            public Bisiklet(int vitesSayisi)
            {
                vites = 1;
                hiz = 0;
                VitesSayisi = vitesSayisi;
            }

            public void VitesDegistir(int yeniVites)
            {
                vites = yeniVites;
            }

            public void Hizlan(int artis)
            {
                hiz += artis;
            }

            public void FrenYap(int azalis)
            {
                hiz -= azalis;
                if (hiz < 0) hiz = 0;
            }

            public void BilgileriYaz()
            {
                Console.WriteLine($"Hız: {hiz}, Vites: {vites}, Vites Sayısı: {VitesSayisi}");
            }
        }
        static void Main(string[] args)
        {
            Bisiklet bisiklet1 = new Bisiklet();
            Bisiklet bisiklet2 = new Bisiklet(21);

            bisiklet1.Hizlan(10);
            bisiklet1.VitesDegistir(3);
            bisiklet1.FrenYap(2);
            bisiklet1.BilgileriYaz();

            bisiklet2.Hizlan(20);
            bisiklet2.VitesDegistir(5);
            bisiklet2.FrenYap(5);
            bisiklet2.BilgileriYaz();

            Console.ReadLine();
        }
    }
}
