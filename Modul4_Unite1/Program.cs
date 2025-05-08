using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_Unite1
{
    class Bisiklet
    {
        int hiz = 0;
        int vites = 0;
        public Bisiklet()
        {
            vites = 18;
        }
        public void Hizlan(int artis)
        {
            hiz = hiz + artis;
        }
        public void BilgileriYaz()
        {
            Console.Write("Vites:{0} ", vites);
            Console.Write("Hız: {0}", hiz);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bisiklet bisiklet1 = new Bisiklet();

            bisiklet1.Hizlan(15);

            Console.WriteLine("Bisiklet1'in Bilgileri:");
            bisiklet1.BilgileriYaz();
            Console.WriteLine(); 

            Bisiklet bisiklet2 = bisiklet1;

            Console.WriteLine("Bisiklet2'nin Bilgileri (Bisiklet1'den alındı):");
            bisiklet2.BilgileriYaz();
            Console.WriteLine();  

            bisiklet2.Hizlan(10);

            Console.WriteLine("Güncellenmiş Bisiklet1 ve Bisiklet2 Bilgileri:");
            bisiklet1.BilgileriYaz();  
            Console.WriteLine();
            bisiklet2.BilgileriYaz();  
        }
    }   
}
