using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D1.StaticKullanimi
{
    public class Ogrenci
    {
        public string Isim {get; set;}
        public string SoyIsim { get; set; } // Hem Field hem de property
        public string EmailAdres { get; set; }

        public void Test1()
        {
            Console.WriteLine("Nesne örneği alındıktan sonra çalışan metottur");
        }

        public static void Test2()
        {
            Console.WriteLine("Nesne örneği alınmadan kullanılabilir");
        }

    }
}
