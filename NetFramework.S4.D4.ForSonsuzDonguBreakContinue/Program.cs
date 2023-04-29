using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Sonsuz Döngü = ram kullanimi çoğalır, ram yetersiz kalırsa harddiskten kullanır, cpu çok ısınır ve bilgisayar kapanır */

namespace NetFramework.S4.D4.ForSonsuzDonguContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac;


            for (sayac = 1; sayac >= 1; sayac++)
            {


                if (sayac == 2 || sayac == 4)
                {
                    continue;
                }
                else if (sayac == 11)
                {
                    break;
                }
                Console.WriteLine("Sonsuz Döngü {0}", sayac);

            }
            Console.ReadLine();
        }
    }



}
