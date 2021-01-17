using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri db'ye eklendi...");
            Console.WriteLine(Convert.ToString(musteri.id)+"- "+musteri.ad+" "+musteri.soyad+" TL Bakiye: "+musteri.bakiye+" TL");
        }

        public void MusteriSil(int id)
        {
            Console.WriteLine("Müşteri kayıtları silindi...");
        }

        public void MusterileriListele(int id)
        {
            Console.WriteLine("");
        }
    }
}
