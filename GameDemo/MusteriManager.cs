using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class MusteriManager : DogrulamaServices, IManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(" Müsteri Eklendi.");
        }

        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine("Müsteri Güncellendi.");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müsteri Silindi.");
        }
    }
}
