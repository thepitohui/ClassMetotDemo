using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri musteri3 = new Musteri();

            musteri1.Id = 534;
            musteri1.Ad = "Muzaffer";
            musteri1.Soyad = "Kılıçaslan";
            musteri1.Bakiye = 2000.00;
            musteri1.Limit = 4000.00;

            musteri2.Id = 122;
            musteri2.Ad = "Maya";
            musteri2.Soyad = "Türkmen";
            musteri2.Bakiye = 34000.00;
            musteri2.Limit = 50000.00;

            musteri3.Id = 543;
            musteri3.Ad = "Sana";
            musteri3.Soyad = "Türkmen";
            musteri3.Bakiye = 600000.00;
            musteri3.Limit = 7000000.00;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            
            MusteriManager musteriManager = new MusteriManager();

            foreach (Musteri musteri in musteriler)
            {
                musteriManager.MusteriEkle(musteri);
            }

            musteriManager.MusteriListele();

            musteriManager.MusteriSil(musteri1);

            Console.WriteLine("*******************************");
            musteriManager.MusteriListele();






        }
    }
}
