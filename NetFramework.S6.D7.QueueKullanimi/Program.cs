using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.S6.D7.QueueKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Q1 = new Queue();

            Q1.Enqueue("Bir");
            Q1.Enqueue("İki");
            Q1.Enqueue("Üç");
            Q1.Enqueue("Dört");

            object O1 = Q1.Peek(); // İçerideki değeri silmez.
            object O2 = Q1.Dequeue(); // İçerideki değeri siler.

            Console.ReadLine();
        }
    }
}
