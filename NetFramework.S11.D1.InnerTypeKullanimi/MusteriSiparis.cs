using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S11.D1.InnerTypeKullanimi
{
    public class MusteriSiparis
    {
        public string SiparisNumarasi;



        public Urun[] UrunArray;

        public MusteriSiparis()
        {
            UrunArray = new Urun[1];
        }
        public void MusteriSiparisMetot()
        {
            Console.WriteLine("Musteri Siparis Test Metot");
        }
    }


}
