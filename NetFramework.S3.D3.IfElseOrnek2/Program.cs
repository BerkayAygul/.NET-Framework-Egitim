using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S3.D3.IfElseOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string adSoyad = string.Empty;

            string stringNot1 = "";
            string stringNot2 = "";
            string stringNot3 = "";

            
            Console.Write("\nAdinizi giriniz: ");
            adSoyad = Console.ReadLine();

            Console.Write("\nSayın {0}, notlarinizi giriniz:\n", adSoyad);

            Console.Write("\n1. Notu Giriniz: ");
            stringNot1 = Console.ReadLine();

            Console.Write("\n2. Notu Giriniz: ");
            stringNot2 = Console.ReadLine();

            Console.Write("\n3. Notu Giriniz: ");
            stringNot3 = Console.ReadLine();



            double notOrtalama = Math.Round((double.Parse(stringNot1) + double.Parse(stringNot2) + double.Parse(stringNot3)) / 3, 2);
       

            Console.Write("\nNotlarinizin ortalamasi = {0}", notOrtalama);

            if(notOrtalama >= 50)
            {
                Console.Write("\n\nDerslerden başarıyla geçtiniz");
            }

            else
            {
                Console.Write("\nDerslerden başarısız oldunuz");
            }
            

            

            Console.ReadLine();
                

           
         }
    }
}
