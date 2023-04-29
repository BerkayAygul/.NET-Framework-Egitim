using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D1.SanalMetotKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                - Kalitim icerisinde kalitilan sinif, kendisini kalitan sinifa icerisindeki private metotlar
                  haricinde bulunan tum metotlara erisim izni sunmaktaydi.

                - Ornek olarak onceki projedeki BaseClass sinifindan Urun sinifi kalitildigi zaman,
                  Urun classi BaseClass sinifinin metotlarina erisebiliyordu.

                - Sanal metotlar kullanilarak kalitilan sinif icerisinde bulunan bir metotun istenilirse 
                  kendisinden tureyen bir sınıfin icerisinde sekillenebilmesi amaclanir.
                
                - Tum nesnelerin object nesnesinden kalitilir ve bazi metotlar object nesnesinden gelir.

                - Ornegin, toString metotu object nesnesinden gelen sanal bir metottur.
                  Istenilirse bu metotun icerigi degistirilebilir.
                
                - toString metotunun standart kullanim sekli Namespace.Class ile cagrilmasidir.
            
                - Framework standart olarak tum nesnelere : Object kalitimi yapar.

                - override keywordu ile bir classin icerisindeki standart sanal metotlarin 
                  davranislari degistirilebilir.
            
                - virtual keywordu ile sonradan yazilan metotlar sanallastirilabilir daha sonra
                  override keywordu ile davranisi degistirilebilir.

                - base = kalitilan nesneyi gosterir (object veya baska bir class).
           
            */

            Musteri M1 = new Musteri();

            M1.Isim = "Louen";
            M1.SoyIsim = "Leoncoeur";

            string ToStringMesaj = M1.ToString();

            Console.WriteLine(ToStringMesaj);


            Console.ReadLine();

        }
    }
}
