using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D7.ForEachKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] Kullanici= new[] { "Test1", "Test2", "Test3", "Test4" };

            foreach (string item in Kullanici)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

    }
}
