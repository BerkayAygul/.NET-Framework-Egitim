using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S14.D1.AbstractKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                - Kurumsal projelerde cok gorulen bu kavramlar kisisel projelerde
                  tasarim deseni zorunlu degilse kullanilmaz.
                
                - Abstract ve Interface tanimlarinda bir nesne ornekleme soz konusu degildir.
             
                - Yapilacak isin nasil yapilacaginin kurallari hazirlanir ve 
                  nesnelerde bu kurallar kullanilir.
             
                - BaseClass bir nevi sablon, bir kural kutuphanesi olarak kullanilir.
                  Bundan sonra yazilanlar bu sablona uyularak yazilir.

                - Abstract classlarin abstract metot bodylari olmaz.
                  Metotun imzasi yazilir ve birakilir.

                - Bu sekilde bir metot kullaniminda kalitim yapilirsa Musteri classi
                  bodysi olmayan bir abstract metot gordugu icin hata verir. 
                  Abstract class implement edilmelidir.

                - Abstract classlar sealed edilemez. Sablon tipinde oldugu icin kalitilmasi
                  gerekir. Sealed edersek kalitilamaz.

                - Abstract classlarin metot bodysi olmadigi icin virtual kullanilamaz.

            */

            Musteri M1 = new Musteri();
            SuperMusteri SP1 = new SuperMusteri();

            M1.Test();

            M1.TestAbstract();
        }
    }
}
