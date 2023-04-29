using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D2.MetotOrnek1
{
    public class Matematik
    {
        public void Menü()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("1- Toplama");
            Console.WriteLine("2- Çıkarma");
            Console.WriteLine("3- Çarpma");
            Console.WriteLine("4- Bölme");
            Console.Write("Bir İşlem Seçiniz: ");
        }
        public decimal ToplamaIslemi (decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 + sayi2;
            return sonuc;
        }

        public decimal CikartmaIslemi (decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 - sayi2;
            return sonuc;
        }

        public decimal CarpmaIslemi (decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 * sayi2;
            return sonuc;
        }

        public decimal BolmeIslemi (decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 / sayi2;
            return sonuc;
        }

        public void EkranaYazdir(decimal kullaniciSayi1, string operators , decimal kullaniciSayi2, decimal sonuc)
        {
            Console.Write("\n{0} {1} {2} = {3} ", kullaniciSayi1, operators, kullaniciSayi2, sonuc);
        }
    }
}
