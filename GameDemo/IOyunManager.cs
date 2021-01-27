using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface IOyunManager
    {
        void Ekle(Oyun oyun);
        void Guncelle(Oyun oyun);
        void Sil(Oyun oyun);
    }
}
