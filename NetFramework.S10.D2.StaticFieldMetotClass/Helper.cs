using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D2.StaticFieldMetotClass
{
    public static class Helper
    {
        /*public void Test()
        {
             Static class icinde static olmayan metotlar, fieldlar, propertyler yazilamaz
             Cunku classin nesne ornegi alinmadan bu tur tanimlar yapilamaz
         }*/
        public static void EmailGonder(string aliciEmailAdres, string konu, string icerik)
        {
            Console.WriteLine("Gonderme islemi basarili");

        }



        static Helper() // Static yapici metotlar private olarak kullanilir, yazilmaz.
        {
            /*
             - Static yapici metotlar uygulama boyunca bir kez calisir. Uygulama boyunca ne kadar cagrilirsa
             cagrilsinlar bir daha calismazlar
             */

            Console.WriteLine("Helper > Static Class > Static CTOR");
        }

        /*public Helper() Standart yapici Metot
         {
            - Her nesne ornegi alindiginda calisir (Helper H1 = new Helper();)
         }*/
    }
}
