using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D2.KapsullemeOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Field değer ataması yapılsın ama değer okunmasın
               Field değer ataması yapılsın ama ilk 4 hanesi okunsun
               Field değer ataması ve okuma işlemi yapılsın ama bu iki işlemde bizim
               belirlediğimiz bir süreçten geçsin ve daha sonra veri gösterilsin
            */

            Musteri M1 = new Musteri();
    

            M1.EmailAdres = "grimgor.ironhide@hotmail.com";
            Console.WriteLine(M1.EmailAdres);


            // 1- Field değer ataması yapılmasın ama değer okunsun


            Console.WriteLine("Musteri Id değeri = {0}", M1.ID.ToString());

            // M1.ID = 100;             Set ile atar, atanmasini istemiyoruz, set private yapılır
        }
    }
}

