using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D1.KapsullemeKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Field değer ataması yapılmasın ama değer okunsun
               Field değer ataması yapılsın ama değer okunmasın
               Field değer ataması yapılsın ama ilk 4 hanesi okunsun
               Field değer ataması ve okuma işlemi yapılsın ama bu iki işlemde bizim
               belirlediğimiz bir süreçten geçsin ve daha sonra veri gösterilsin
            */
             
            /* Class - Field - Property - Get & Set */

            Musteri M1 = new Musteri();

            M1.id = 1;
            M1.isim = "Grimgor";
            M1.soyisim = "Ironhide";
            
          /*  M1.emailAdres = "grimgor.ironhide@hotmail.com"; 
              Field Değil Property Çağır
          */

            M1.EmailAdres = "grimgor.ironhide@hotmail.com";

            Console.WriteLine(M1.EmailAdres);

        }
    }
}
