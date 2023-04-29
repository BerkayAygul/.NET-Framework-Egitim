using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D5.ForIcIceOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;

            for (i=1; i<=10; i++)
            {
                for(j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
