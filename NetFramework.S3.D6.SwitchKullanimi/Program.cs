using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S3.D6.SwitchKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringSayi1 = string.Empty;
            string stringSayi2 = string.Empty;
            string secilenIslem = string.Empty;
            double yapilacakIslem = 0;

            Console.Write("1. Sayıyı Giriniz: ");
            stringSayi1 = Console.ReadLine();
            Console.Write("\n2. Sayıyı Giriniz: ");
            stringSayi2 = Console.ReadLine();

            double doubleSayi1 = Convert.ToDouble(stringSayi1);
            double doubleSayi2 = Convert.ToDouble(stringSayi2);

            Console.WriteLine("\nSeçilen Sayılar:  Birinci Sayı = {0} ,  İkinci Sayı = {1}", doubleSayi1, doubleSayi2);

            Console.WriteLine("\nAşağıdaki işlemlerden birini seçiniz: ");
            Console.WriteLine("1- Toplama");
            Console.WriteLine("2- Çıkarma");
            Console.WriteLine("3- Çarpma");
            Console.WriteLine("4- Bölme\n");

            secilenIslem = Console.ReadLine();
            Console.WriteLine("");

            switch (secilenIslem)
            {
                case "1":
                    yapilacakIslem = doubleSayi1 + doubleSayi2;
                    Console.WriteLine("Sayıların Toplamı = {0}", yapilacakIslem);
                    break;
                case "2":
                    yapilacakIslem = doubleSayi1 - doubleSayi2;
                    Console.WriteLine("Sayıların Çıkarımı = {0}", yapilacakIslem);
                    break;
                case "3":
                    yapilacakIslem = doubleSayi1 * doubleSayi2;
                    Console.WriteLine("Sayıların Çarpımı = {0}", yapilacakIslem);
                    break;
                case "4":
                    yapilacakIslem = doubleSayi1 / doubleSayi2;
                    Console.WriteLine("Sayıların Bölümü = {0}", yapilacakIslem);
                    break;
                default:
                    Console.WriteLine("Aralık Dışı Değer Girildi.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
