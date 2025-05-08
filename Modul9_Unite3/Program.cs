using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9_Unite3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplamen = Program.toplam(9, 4, 5, 6, 19);
            Console.WriteLine("En küçük ve en büyük sayıların toplamı: " + toplamen);
            Console.Read();
        }
        public static int toplam(params int[] paramList)
        {
            int c = paramList[0];
            int d = paramList[0];

            foreach (int i in paramList)
            {
                if (i < c)
                    c = i;
            }
            foreach (int i in paramList)
            {
                if (i > d)
                    d = i;
            }

            return c + d;
        }
    }
}
