using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S3.D4.IfElseIfKullanimi
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

            double doubleNot1 = double.Parse(stringNot1);

            double doubleNot2 = double.Parse(stringNot2);

            double doubleNot3 = double.Parse(stringNot3);

            double notOrtalama = Math.Round((doubleNot1 + doubleNot2 + doubleNot3) / 3, 2);

            Console.Write("\nNotlarinizin ortalamasi = {0}\n\n", notOrtalama);

            if (notOrtalama > 0 && notOrtalama < 40) Console.WriteLine("Derslerinizden Kaldınız.");
            else if (notOrtalama >= 40 && notOrtalama < 60) Console.WriteLine("Derslerinizden Sorumlu Geçtiniz.");
            else if (notOrtalama >= 60 && notOrtalama <= 100) Console.WriteLine("Derslerinizden Başarıyla Geçtiniz.");
            else Console.WriteLine("Yanlış Not Değerleri Girildi.");

            Console.ReadLine();
        }
    }
}
