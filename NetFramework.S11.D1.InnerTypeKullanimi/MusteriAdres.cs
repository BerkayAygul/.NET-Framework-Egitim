using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S11.D1.InnerTypeKullanimi
{
    public class MusteriAdres
    {
        public string AdresinTipi;
        public string Il;
        public string Ilce;
        public string Adres;

        public MusteriAdres()
        {
            Console.WriteLine("Musteri adres yapici metot");
        }

        public void MusteriAdresMetot()
        {
            Console.WriteLine("Musteri adres test metot");
        }
    }
}
