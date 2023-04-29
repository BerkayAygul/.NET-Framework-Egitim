using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S5.D3.DiziOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
               20 elemanlı int dizisi oluştur.
               Random fonksiyonu ile 1-10 arasındaki değerleri kullanarak diziyi doldur.
               Dizi içerisindeki elemanları yazdır.
               Dizi içerisinde kaç tane "4" elemanı olduğunu ekrana yazdır.
            */
          
            int[] diziElemanlari = new int[20];
            int randomSayilar;

            Random rnd = new Random();

            Console.WriteLine("Elemanlar:\n");

            for (int sayac = 0; sayac < diziElemanlari.Length; sayac++)
            {
                randomSayilar = rnd.Next(1, 10);
                diziElemanlari[sayac] = randomSayilar;
                Console.Write("{0} ", randomSayilar);
            }

            int dortleriBul = 0;

            foreach (int item in diziElemanlari)
            {
                if (item==4)
                {
                    dortleriBul++;
                }    
            }

            Console.WriteLine("\n4 Elemanların sayisi = {0}", dortleriBul);

            Console.ReadLine();



        }
    }
}
