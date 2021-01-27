using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface IKampanyaManager
    {
        void Ekle(Kampanya kampanya);
        void Guncelle(Kampanya kampanya);
        void Sil(Kampanya kampanya);
    }
}
