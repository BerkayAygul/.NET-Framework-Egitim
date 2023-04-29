using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S11.D1.InnerTypeKullanimi
{
    public class Urun
    {
        public int UrunID;
        public string Tanim;
        public decimal Fiyat;

        public Urun()
        {
            Console.WriteLine("Urun yapici metot");
        }

        public void UrunMetot()
        {
            Console.WriteLine("Urun test metot");
        }

    }
}
