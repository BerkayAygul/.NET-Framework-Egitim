using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D6.ForIcIceOrrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int carpim;
            

            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    carpim = i * j;
                    
                    Console.Write("{0}x{1}={2}\t", i, j, carpim);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
