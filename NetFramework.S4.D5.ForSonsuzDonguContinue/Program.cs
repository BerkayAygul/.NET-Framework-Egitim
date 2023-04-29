using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D5.ForSonsuzDonguContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac;


            for(sayac=1; sayac>=1; sayac++)
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
