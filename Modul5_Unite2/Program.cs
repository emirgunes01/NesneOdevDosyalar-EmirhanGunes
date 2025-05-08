using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5_Unite2
{
    internal class Program
    {
        class Nokta
        {
            private int x, y;
            private static int noktaSayisi = 0;

            public Nokta()
            {
                this.x = 0;
                this.y = 0;
                noktaSayisi++;
            }
            public Nokta(int x, int y)
            {
                this.x = x;
                this.y = y;
                noktaSayisi++;
            }
            public static int NoktaSayisi()
            {
                return noktaSayisi;
            }
        }
        static void Main(string[] args)
        {
            Nokta nokta1 = new Nokta();
            Nokta nokta2 = new Nokta(3, 4);
            Nokta nokta3 = new Nokta(7, 8);

            Console.WriteLine("Oluşturulan toplam nokta sayısı: " + Nokta.NoktaSayisi());

            Console.ReadLine();
        }
    }
}
