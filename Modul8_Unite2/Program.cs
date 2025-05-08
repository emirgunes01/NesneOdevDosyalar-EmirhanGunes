using System;

namespace Modul8_Unite2
{
    internal class Program
    {
        public class Urun
        {
            public string Ad { get; set; }
            public decimal Fiyat { get; set; }

            public Urun(string ad, decimal fiyat)
            {
                Ad = ad;
                Fiyat = fiyat;
            }
        }
        public class Sepet
        {
            public event EventHandler<Urun> UrunEklendi;
            private decimal toplamTutar = 0;

            public void UrunEkle(Urun urun)
            {
              
                UrunEklendi?.Invoke(this, urun);
            }

            public void UrunEklendigindeToplamTutarHesapla(object sender, Urun urun)
            {
                toplamTutar += urun.Fiyat;
                Console.WriteLine($"Yeni ürün eklendi: {urun.Ad}, Fiyat: {urun.Fiyat} TL");
                Console.WriteLine($"Toplam tutar: {toplamTutar} TL");
            }
        }
        public class Makine
        {
            public event EventHandler SıcaklıkYüksek; 
            private Random random = new Random();
            private double sıcaklık;

            public void SıcaklıkKontrol()
            {
                sıcaklık = random.NextDouble() * 1200; 
                Console.WriteLine($"Makine sıcaklığı: {sıcaklık}°C");

                if (sıcaklık > 1000)
                {
                    SıcaklıkYüksek?.Invoke(this, EventArgs.Empty);
                }
            }
            public void MakineyiKapat(object sender, EventArgs e)
            {
                Console.WriteLine("Sıcaklık 1000°C'yi geçti! Makine kapatılıyor.");
            }
        }
        static void Main(string[] args)
        {
            Sepet sepet = new Sepet();
            Makine makine = new Makine();

            sepet.UrunEklendi += sepet.UrunEklendigindeToplamTutarHesapla;

            sepet.UrunEkle(new Urun("Elma", 15.5m));
            sepet.UrunEkle(new Urun("Muz", 12.75m));
            sepet.UrunEkle(new Urun("Armut", 20.0m));

            makine.SıcaklıkYüksek += makine.MakineyiKapat;

            for (int i = 0; i < 5; i++) 
            {
                makine.SıcaklıkKontrol();
                System.Threading.Thread.Sleep(1000);
            }

            Console.ReadLine();
        }
    }
}
