using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D1.KalitimKullanimi
{
    public class Ogrenci:TemelTip
    {
        public string Bolum { get; set; }
        public int Seviye { get; set; }

        public Ogrenci()
        {
            Console.WriteLine("Ogrenci nesnesi yapici metotu calisti");
            TemelTipMetot2();

        }



    }
}
