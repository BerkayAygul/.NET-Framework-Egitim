using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S3.D7.GoToKullanimi
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
                    Console.WriteLine("Ocak");
                    break;
                case "2":
                    Console.WriteLine("Şubat");
                    break;
                case "3":
                    Console.WriteLine("Mart");
                    break;
                case "4":
                    Console.WriteLine("Nisan");
                    break;
                case "5":
                    Console.WriteLine("Mayıs");
                    break;
                case "6":
                    Console.WriteLine("Haziran");
                    break;
                case "7":
                    Console.WriteLine("Temmuz");
                    break;
                case "8":
                    Console.WriteLine("Ağustos");
                    break;
                case "9":
                    Console.WriteLine("Eylül");
                    break;
                case "10":
                    Console.WriteLine("Ekim");
                    break;
                case "11":
                    Console.WriteLine("Kasım");
                    break;
                case "12":
                    Console.WriteLine("Aralık");
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
