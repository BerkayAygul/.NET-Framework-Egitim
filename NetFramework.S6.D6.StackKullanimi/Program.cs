using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.S6.D6.StackKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Listedeki bilgilerle işlem yaptıktan sonra listedeki dataların boşaltılması
            // En son gelen data ilk çıkar

            Stack S1 = new Stack();

            S1.Push("Bir");
            S1.Push("İki");
            S1.Push("Üç");
            S1.Push("Dört");

            object O1 = S1.Pop(); // Datayı çıkarır.
            object O2 = S1.Peek(); // Datayı önizleme yapar, çıkartmaz.

            Console.ReadLine();
        }
    }
}
