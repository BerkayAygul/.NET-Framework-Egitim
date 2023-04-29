using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D92.WhileOrnek4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sistemin Verdiği 1-10 Arasındaki Sayılardan Birini Tahmin Etme

            int sistemUretimi;
            int tahminSayisi = 1;
            string kullaniciTahmin = string.Empty;

            Random rnd = new Random();
            sistemUretimi = rnd.Next(1, 10);

            while(true)
            {
                Console.Write("\n{0} Deneme, Sayıyı Tahmin Et: ", tahminSayisi);
                kullaniciTahmin = Console.ReadLine();

                if(int.Parse(kullaniciTahmin) == sistemUretimi)
                {
                    
                    Console.WriteLine("{0}. Denemenizde Sayıyı Doğru Tahmin Ettiniz\n", tahminSayisi);
                    break;
                }
                else if (int.Parse(kullaniciTahmin) != sistemUretimi && int.Parse(kullaniciTahmin) <=10)
                {
                    Console.WriteLine("{0}. Kez Yanlış Tahmin Ettiniz, Tekrar Deneyiniz", tahminSayisi);
                    tahminSayisi++;
                }
                else
                {
                    Console.WriteLine("\nSayılar 1-10 Arasında!");
                }
            }

            Console.ReadLine();
            #endregion
        }
    }
}
