using System;

namespace Modul7_Unite1
{
    internal class Insan
    {
        public double Boy, Kilo;
        public string Ad;

        public Insan(string ad)
        {
            this.Ad = ad;
            this.Boy = 0.45;
            this.Kilo = 3.5;
        }

        public void Buyu()
        {
            Boy += 0.5;
            Kilo += 0.5;
        }
    }

    internal class Ogrenci : Insan
    {
        public Ogrenci(string ad) : base(ad)
        {
        }
    }

    internal class Ogretmen : Insan
    {
        public Ogretmen(string ad) : base(ad)
        {
        }
    }

    internal class Mudur : Insan
    {
        public Mudur(string ad) : base(ad)
        {
        }
    }
}
