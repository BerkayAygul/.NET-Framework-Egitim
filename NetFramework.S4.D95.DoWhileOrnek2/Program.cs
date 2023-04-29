using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D95.DoWhileOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Kullanicidan 1 ila x arası sayi girişi iste. Sistem 1 ila x arasında sayı tahmin etsin.
               Daha sonra Kullanıcı sistemin tahmin ettiği sayıyı bulmaya çalışsın. 
               Kullanıcı sayıyı bulana kadar deneme sayisi y olarak yazsin. */

            #region 
            
            string ustLimit = string.Empty;
            int sistemTahmin;
            string kullaniciTahmin = string.Empty;
            int tahminSayisi = 0;

            GeriDon:

            Console.WriteLine("Sayiniz 1 ile hangi sayi arasinda olsun?");
            Console.Write("x üst değerini giriniz: ");
            ustLimit = Console.ReadLine();
            int x = int.Parse(ustLimit);

            if(x<=1)
            {
                Console.WriteLine("\n1'den büyük bir doğal sayı giriniz!\n");
                goto GeriDon;
            }

            else
            { 
                Random rnd = new Random();
                sistemTahmin = rnd.Next(1, x);

                do
                {
                    tahminSayisi++;

                    Console.Write("{0}. Tahmin, bir sayı tahmin ediniz: ", tahminSayisi);
                    kullaniciTahmin = Console.ReadLine();
                    

                } while (int.Parse(kullaniciTahmin) != sistemTahmin);

                Console.WriteLine("\n{0}. denemenizde doğru tahmin ettiniz", tahminSayisi);
            }

            Console.ReadLine();
            #endregion
        }
    }
}
