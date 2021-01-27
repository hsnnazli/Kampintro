using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class OyunManager:IOyunManager
    {
        public void Ekle(Oyun oyun)
        {
            Console.WriteLine(" Oyun Eklendi.");
        }

        public void Guncelle(Oyun oyun)
        {
            Console.WriteLine(" Oyun Güncellendi.");
        }

        public void Sil(Oyun oyun)
        {
            Console.WriteLine(" Oyun Silindi.");
        }
    }
}
