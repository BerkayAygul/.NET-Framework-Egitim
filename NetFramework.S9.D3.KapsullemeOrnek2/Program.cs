using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D3.KapsullemeOrnek2
{
    class Program
    {
        // 3- Field değer ataması yapılsın ama ilk 3 hanesi okunsun
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();

            M1.TCKimlikNo = "11223344556";


            Console.WriteLine("{0}", M1.TCKimlikNo);

            Console.ReadLine();
        }
    }
}
