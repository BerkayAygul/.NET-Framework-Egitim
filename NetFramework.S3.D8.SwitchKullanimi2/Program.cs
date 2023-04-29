using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S3.D8.SwitchKullanimi2
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciDegeri = string.Empty;

        // Başlık Yazıyoruz, iki nokta kullanarak (label yazımı)

        YenidenSecim:

            Console.Write("Bulunduğunuz ayın sayısal değerini yazınız: ");
            kullaniciDegeri = Console.ReadLine();


            Console.WriteLine("");


            switch (kullaniciDegeri)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                    Console.WriteLine("İlk 4 ay içinde");
                    break;
                case "5":
                case "6":
                case "7":
                case "8":
                    Console.WriteLine("İkinci 4 ay içinde");
                    break;
                case "9":
                case "10":
                case "11":
                case "12":
                    Console.WriteLine("Üçüncü 4 ay içinde");
                    break;

                default:
                    Console.WriteLine("Yanlış değer girildi");
                    Console.WriteLine("");
                    goto YenidenSecim;

            }
            Console.ReadLine();
        }
    }
}
