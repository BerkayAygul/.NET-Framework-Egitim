using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S1.D1.DegiskenNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim;
            isim = "Baudouin";

            Console.Write("Kullanıcı Adı: ");
            Console.WriteLine(isim);

            int i = 1;
            int y = 2;

            Console.Write("i'nin değeri: ");
            Console.WriteLine(i);
            Console.Write("y'nin değeri: ");
            Console.WriteLine(y);

            Console.WriteLine();

            int sayi1 = 0;
            sayi1 = int.MinValue;
            Console.Write("En düşük  int değeri: ");
            Console.WriteLine(sayi1);
           

            sayi1 = int.MaxValue;
            Console.Write("En yüksek int değeri: ");
            Console.WriteLine(sayi1);

            Console.WriteLine();

            double sayi2 = 0;
            sayi2 = double.MinValue;
            Console.Write("En düşük  double değeri: ");
            Console.WriteLine(sayi2);

            sayi2 = double.MaxValue;
            Console.Write("En yüksek double değeri: ");
            Console.WriteLine(sayi2);

            Console.WriteLine();

            float sayi3 = float.MinValue;
            Console.Write("En düşük  float değeri: ");
            Console.WriteLine(sayi3);

            sayi3 = float.MaxValue;
            Console.Write("En yüksek float değeri: ");
            Console.WriteLine(sayi3);

            Console.WriteLine();


            int sayi4 = int.MaxValue;

            {
                int toplam = 25;
                Console.Write("Toplam değeri: ");
                Console.WriteLine(toplam);

                toplam = 50;

                sayi4 = 100;

            }
            Console.Write("sayi4  değeri: ");
            Console.WriteLine(sayi4);


            Console.ReadLine();
        }
    }
}
