using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S3.D2.IfElseOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullanici = "";
            string sifre = "";

            Console.Write("Kullanici adini giriniz: ");
            kullanici = Console.ReadLine();

            Console.Write("Sifrenizi giriniz: ");
            sifre = Console.ReadLine();

            if (kullanici == "Demo" && sifre == "1234")
            {
                Console.WriteLine("\nGiris basarili");
            }
            else
            {
                Console.WriteLine("Yanlis kullanici adi veya sifre");
            }

            Console.ReadLine();
        }
    }
}
