using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D4.ForSonsuzDonguBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac;

            for (sayac = 1; sayac >= 1; sayac++)
            {

                Console.WriteLine("Sonsuz Döngü {0}", sayac);

                if (sayac == 10)
                {
                    break;
                }

            }
            Console.ReadLine();
        }
    }
}
