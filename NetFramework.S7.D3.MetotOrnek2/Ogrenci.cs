using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D3.MetotOrnek2
{
    public class Ogrenci
    {

        /* Opsiyonel parametre
        public void ogrenciNotHesapla(string ad, string soyad, decimal not1, decimal not2, decimal not4, decimal not3 = 45)*/
        public void Islem (string adSoyad, decimal not1, decimal not2, decimal not3)
        {
            Console.WriteLine("\n\nOgrencinin Bilgileri Assagidaki Gibidir: ");
            Console.WriteLine("\nAd Soyad = {0}" , adSoyad);

            OrtalamaNotDegerlendir(Math.Round(OrtalamaHesapla(not1 , not2 , not3),2));
            

            void OrtalamaNotDegerlendir(decimal ogrenciOrtalama)
            {
                if (ogrenciOrtalama < 45)
                {
                    Console.WriteLine("\nDerslerden {0} Ortalama ile Kaldiniz.", ogrenciOrtalama);
                }
                else
                {
                    Console.WriteLine("\nDerslerden {0} Ortalama ile Geçtiniz.", ogrenciOrtalama);
                }

            }




        }

        private decimal OrtalamaHesapla(decimal OgrenciNot1, decimal OgrenciNot2, decimal OgrenciNot3)
        {
            /* decimal ortalama = (OgrenciNot1 + OgrenciNot2 + OgrenciNot3) / 3;
             return ortalama;*/

            //Daha Kısası

            return (OgrenciNot1 + OgrenciNot2 + OgrenciNot3) / 3;
        }

 
    }
}
