﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebeikler!Sepete eklendi :" + urun.Adi);

        }
        
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi )
        {
            Console.WriteLine("Tebeikler!Sepete eklendi :" + urunAdi);
        }
    }
}
