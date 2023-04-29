using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D9.WhileOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Kullanici Degerini Ekranda 1 Eksiltip 0'a Ulaşana Kadar Yazma

            string k = string.Empty;
            int i;

            Console.Write("Bir doğal sayi giriniz: ");
            k = Console.ReadLine();

            i = int.Parse(k);

            while (i!=0)
            {
                Console.WriteLine(i);
                i--;
            }
            #endregion

            Console.ReadLine();
        }
    }
}
