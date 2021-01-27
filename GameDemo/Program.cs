using System;
using System.Collections.Generic;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri { DogTarihi = new DateTime(1984, 11, 11), Id = 1, MusteriAdi = "Hüseyin", MusteriSoyad = "Nazlı", TcNo = "12345678909" };
            IManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            DogrulamaServices dogrulamaServices = new DogrulamaServices();
            dogrulamaServices.Dogrula();

            Oyun oyun1 = new Oyun { Id = 1, OyunAdi = "Süper Mario", OyunFiyati = 100 };
            OyunManager oyunManager = new OyunManager();
            oyunManager.Ekle(oyun1);

            Kampanya kampanya1 = new Kampanya { Id = 1, KampanyaAdi = "%20 İndirim", IndirimOrani = 20 };
            KampanyaManager kampanyaManager = new KampanyaManager();
            kampanyaManager.Ekle(kampanya1);

            List<Musteri> musteriler = new List<Musteri>() { musteri1 };
            List<Oyun> oyunlar = new List<Oyun>() { oyun1 };
            List<Kampanya> kampanyalar = new List<Kampanya>() { kampanya1 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi + " ", musteri.MusteriSoyad + " isimli oyuncu ");
                foreach (var oyun in oyunlar)
                {
                    Console.WriteLine(oyun.OyunAdi+" İsimli oyunu ");
                    foreach (var kampanya in kampanyalar)
                    {
                        Console.WriteLine(kampanya.KampanyaAdi+"ile satın aldı.");
                    }
                }
            }

            Console.ReadLine();


        }
    }
}
