using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S14.D2.InterfaceKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                - Interface kisminda tamamen sablonun icerisine girilir.
                
                - Interface bir item olarak kullanilir. Class degildir.

                - Itemin ismini koyarken kural olarak I harfi yazilarak baslanir.

                - Abstracttan farki, gercekten sablon olusturmasidir.
            
                - Abstracttan daha fazla kullanilirlar.

                - Interface'de yapici metot kullanilamaz.
                
                - Interface'de tanimlarin bodyleri olmaz.
            
                - Field, metot, delege... Interface icerisinde kullanilabilir.

                - Public interface'de property tanimi yaparken public yazilmaz.
                  
                - Interface'den bir classa kalitim yaparken interface icerisindeki
                  tanimlarin classa aktarilmasi icin tanimlar implement yapilmalidir.

             */
            Musteri M1 = new Musteri();

            M1.KayitDuzenle(15, "Berkay", "Aygül");
            
            Console.ReadKey();
        }
    }
}
