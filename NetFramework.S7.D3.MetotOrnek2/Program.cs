using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D3.MetotOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {

            Ogrenci O = new Ogrenci(); 

            Console.Write("Ad ve Soyad Giriniz: ");
            string girAdSoyad = Console.ReadLine(); 

            Console.Write("\n1. Notu Giriniz: ");
            decimal girNot1 = decimal.Parse(Console.ReadLine());

            Console.Write("\n2. Notu Giriniz: ");
            decimal girNot2 = decimal.Parse(Console.ReadLine());

            Console.Write("\n3. Notu Giriniz: ");
            decimal girNot3 = decimal.Parse(Console.ReadLine());

            O.Islem(girAdSoyad, girNot1, girNot2, girNot3);

            Console.ReadLine();

            
        }
    }
}
