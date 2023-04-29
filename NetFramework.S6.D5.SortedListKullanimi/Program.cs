using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.S6.D5.SortedListKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // HashTable ama keyleri sıralar

            SortedList SortedL = new SortedList();

            SortedL.Add(100, "Yüz");
            SortedL.Add(200, "İki Yüz");
            SortedL.Add(0, "Sıfır");
            SortedL.Add(1000, "Bin");
            // String ile sayıları birlikte sıralamaz.

            foreach (var item in SortedL.Keys)
            {
                Console.WriteLine("{0} , {1}", item, SortedL[item]);
            }
            Console.ReadLine();
        }
    }
}
