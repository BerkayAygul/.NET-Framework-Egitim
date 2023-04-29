using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D8.WhileOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Ekrana 1-10 Arası değerleri yazdır

            int i = 0;

            while (i <= 10)
            {
                Console.WriteLine("{0}", i);
                i++;
            }

            #endregion

            Console.ReadLine();
        }
    }
}
