using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// interface IInsan
// {
//     void Buyu();
//     void Oku();
// }

namespace Modul7_Unite2
{
    internal class OkulYonetim
    {
    }

    /*
    class Ogrenci : IInsan
    {
        public void Buyu()
        {
            Console.WriteLine("Hızlı büyüdüm.");
        }

        public void Oku()
        {
            Console.WriteLine("Okudum.");
        }
    }

    class Ogretmen : IInsan
    {
        public void Buyu()
        {
            Console.WriteLine("Yavaş büyüdüm.");
        }

        public void Oku()
        {
            Console.WriteLine("Okudum.");
        }
    }
    */

    abstract class OkuyanInsan
    {
        public void Oku()
        {
            Console.WriteLine("Okudum.");
        }
    }

    interface IInsan
    {
        void Buyu();
    }

    class Ogrenci : OkuyanInsan, IInsan
    {
        public void Buyu()
        {
            Console.WriteLine("Hızlı büyüdüm.");
        }
    }

    class Ogretmen : OkuyanInsan, IInsan
    {
        public void Buyu()
        {
            Console.WriteLine("Yavaş büyüdüm.");
        }
    }
}
