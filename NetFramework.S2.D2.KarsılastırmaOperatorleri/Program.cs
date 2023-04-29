using System;

namespace NetFramework.S2.D2.KarsılastırmaOperatorleri
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Operatörler Listesi
            /*

            < Küçüktür
            > Büyüktür
            <= Küçük Eşittir
            >= Büyük Eşittir
            == Eşittir
            != Eşit Değildir
            is : Tür Dönüşümlerinde Kullanılır
            as : Tür Dönüşümlerinde Kullanılır

            */
            #endregion
            /*
            int sayi1 = 10;
            int sayi2 = 20;
            */

            #region Bool Tanım

            /*
            
            bool kucukOperatorSonuc = sayi1 < sayi2;

            Console.WriteLine(kucukOperatorSonuc);
            */

            #endregion


            #region is ve as Operatörleri Tanım

            object obje1 = "Test1";

            bool veriTipiKontrol1 = obje1 is int;


            object obje2 = "Test2";

            string veriTipiKontrol2 = obje2 as string;

            /* hata verir sayi1 = (int)obje1; */



            #endregion

        }
    }
}
