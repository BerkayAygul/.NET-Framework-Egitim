using System;
using System.Threading;

namespace NetFramework.S2.D1.AritmetikselOperatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Operator - Toplama

            /*
             string kullanicidanGelenDeger1 = string.Empty;
             string kullanicidanGelenDeger2 = string.Empty;

             int toplamaSayi1 = 0;
             int toplamaSayi2 = 0;
             int toplamaToplam = 0;

             Console.WriteLine("1. Sayiyi Giriniz:");
             kullanicidanGelenDeger1 = Console.ReadLine();

             Console.WriteLine("2. Sayiyi Giriniz");
             kullanicidanGelenDeger2 = Console.ReadLine();

             toplamaSayi1 = int.Parse(kullanicidanGelenDeger1);
             toplamaSayi2 = int.Parse(kullanicidanGelenDeger2);

             toplamaToplam = toplamaSayi1 + toplamaSayi2;

             Console.WriteLine("Girilen sayilarin toplami: " + toplamaToplam);

             */

            #endregion

            #region Operator - Cikarma

            /*
             
            int cikartmaSayi1 = 100;
            int cikartmaSayi2 = 50;
            int cikartmaToplam = cikartmaSayi1 - cikartmaSayi2;

            Console.WriteLine("Cikartma islemi sonucu : {0}", cikartmaToplam);
            Console.ReadLine();

            */

            #endregion

            #region Operator - Çarpma, Bölme, Mod Alma

            /* Çarpma, Bölme ve mod alma için de aynı */

            #endregion

            #region Operator - ++ ve --

            int aritmatikselSayi = 40;


            aritmatikselSayi++;
            aritmatikselSayi--;

            aritmatikselSayi += 5; 


            #endregion

        }
    }
}
