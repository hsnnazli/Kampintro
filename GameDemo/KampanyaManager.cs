using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class KampanyaManager : IKampanyaManager
    {
        public void Ekle(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void Guncelle(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }

        public void Sil(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya Silindi");
        }
    }
}
