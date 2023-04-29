using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S11.D1.InnerTypeKullanimi
{
    public class MusteriIletisim
    {
        public int IletisimTipi;    //717770001: Mobil ,    717770002: Sabit Hat
        public string Numara;
        public bool NumaraAktifligi;

        public void MusteriIletisimMetot()
        {
            Console.WriteLine("Musteri Iletisim Test Metot");
        }
    }
}
