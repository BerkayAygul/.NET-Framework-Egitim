using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D1.KalitimKullanimi
{
    public class Personel:TemelTip
    {
        public DateTime IsBaslangicTarihi { get; set; }
        public DateTime IsBitisTarihi { get; set; }
        public int IzinGunuSayisi { get; set; }

        public Personel()
        {
            Console.WriteLine("Personel nesnesi yapici metotu calisti");
        }
        
    }
}
