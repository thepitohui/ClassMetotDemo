using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> musteriler = new List<Musteri>();

        public void MusteriEkle(Musteri musteri)
        {
            musteriler.Add(musteri);

        }

        public void MusteriListele()
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı:"+musteri.Ad);
                Console.WriteLine("Müşteri Soyadı:"+musteri.Soyad);
                Console.WriteLine("Müşteri Bakiyesi:"+musteri.Bakiye);
                Console.WriteLine("Müşteri Limiti:"+musteri.Limit);
                Console.WriteLine("---------------------");
            }

        }

        public void MusteriSil(Musteri musteri)
        {
            musteriler.Remove(musteri);

        }
    
    }
}
