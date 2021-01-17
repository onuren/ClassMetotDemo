using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();

            Console.WriteLine("Müşteri numarasını giriniz:");
            musteri.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Müşteri adını giriniz:");
            musteri.ad = Console.ReadLine();
            Console.WriteLine("Müşteri soyadını giriniz:");
            musteri.soyad = Console.ReadLine();
            Console.WriteLine("Yatırılan bakiye miktarını giriniz:");
            musteri.bakiye = Convert.ToInt32(Console.ReadLine());

            MusteriManager manager = new MusteriManager();
            manager.MusteriEkle(musteri);
        }
    }
}
