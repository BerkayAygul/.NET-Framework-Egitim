using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D4.RefOutKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Değer tipli davranışların referans tipli davranış olmasını sağlar
            
            // Amaç, değişkenin bütünlüğünü bozmamak için, ilgili değişkenin kopyasını oluşturmak yerine değişkeni takip etmek 

            int sayi1 = 0;

            degerAta(ref sayi1);

            // Params istenilen değerleri diziye çevirip işlem yapar
            topla(5, 9, 20, 45, 22, 12, 11, 56);

            Console.ReadLine();
        }

        static void degerAta(ref int gelenDeger)
            {
                gelenDeger = 10;
            }

        static void topla(params int[] sayilar)
        {
            int toplam = 0;
            for (int i=0; i<sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            Console.WriteLine("Toplam = {0}", toplam);
        }
        
    }
}
