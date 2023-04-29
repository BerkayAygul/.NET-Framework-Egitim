using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S1.D4.TurDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bilinçli Tür Dönüşümü

            byte sayi1 = byte.MaxValue;
            sayi1      = byte.MinValue;


            int sayi2 = 125;

            sayi1 = (byte)sayi2;

            Console.WriteLine(sayi1);

            //Bilinçsiz Tür Dönüşümü

            double sayi3 = 10;

            sayi3 = sayi2;  //Double'nin değeri integer değerinden daha büyük olduğu için sayi2 üstündeki değeri kabul eder

            Console.WriteLine(sayi3);

            //Checked - Unchecked: Değer kaybı yaşanması durumunda hata olarak bildir veya bildirme, işleme devam et

            sayi2 = 512;
            sayi1 = (byte)sayi2;

            Console.WriteLine(sayi1);

            /*checked
            {
                sayi2 = 512;
                sayi1 = (byte)sayi2;
                Console.WriteLine(sayi1);
            }*/

            unchecked
            {
                sayi2 = 512;
                sayi1 = (byte)sayi2;
                Console.WriteLine(sayi1);
            }

            // Object, bir veri tipi olarak, tüm .net veri tiplerinin atasıdır.

            object temelTip = sayi2;
            temelTip = sayi3;

            temelTip = new
            {
                marka = "Opel",
                model = "Corsa",
            };

            /* Boxing */  temelTip = sayi2;
            /*Unboxing*/  sayi2 = (int)temelTip;

            Console.ReadLine();
        }
    }
}
