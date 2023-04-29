using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D2.ForOrnek1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1-10 Arasındaki Sayıları Yaz

            for (int i=1; i<=10; i++)
            {
                Console.WriteLine("{0}. Tekrar", i);
            }


            #endregion

            Console.WriteLine();

            #region 1-100 Arasındaki Çift Sayıların Toplamını Yaz

            int toplam = 0;

            for (int a = 0; a <= 100; a++)
            {
                if(a%2 == 0)
                {
                    toplam += a; // toplam = a + toplam; 
                    Console.WriteLine("{0}", toplam);
                }
            }
            #endregion
            Console.WriteLine("Toplam = {0}", toplam);

            Console.ReadLine();
        }
    }
}
