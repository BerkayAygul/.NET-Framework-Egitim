using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D91.WhileOrnek3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Kullanicidan Gelen Değerleri Topla, 0 Girilirse İşlemi Bitir

            string k = string.Empty;
            int i;
            int toplam = 0;

            Console.WriteLine("Toplanacak Değerleri Giriniz");
            Console.WriteLine("0 Girilmesi Takdirde İşlem Durur");
            



            while (true)
            {
                k = Console.ReadLine();
                i = int.Parse(k);

                if (i != 0)
                {
                    toplam = i + toplam;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("\nToplamlari ={0}" , toplam);

            Console.ReadLine();
            #endregion

        }
    }
}
