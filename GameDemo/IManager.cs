using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface IManager
    {
        void Ekle(Musteri musteri);
        void Guncelle(Musteri musteri);
        void Sil(Musteri musteri);

    }
}
