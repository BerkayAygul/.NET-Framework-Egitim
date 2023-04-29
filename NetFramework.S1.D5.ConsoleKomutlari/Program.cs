using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1.D5.ConsoleKomutları
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullanıcıdanGelenDeger = string.Empty;



            Console.Clear(); //Console datalarını silmek için

            //

            Console.Write("Lütfen adinizi giriniz: ");
            kullanıcıdanGelenDeger = Console.ReadLine();


            //mesaj gösterme yöntemleri

            //1.

            string mesaj = "Girmiş olduğunuz isim değeri: " + kullanıcıdanGelenDeger;
            Console.WriteLine(mesaj);

            Console.Clear();

            //2.


            mesaj = string.Format("Girmiş olduğunuz isim değeri: {0}", kullanıcıdanGelenDeger);

            Console.Clear();
            //3.

            Console.WriteLine("Girmiş olduğunuz isim değeri: {0}", kullanıcıdanGelenDeger);

            Console.Clear();

            // Parse & Convert

            Console.Write("Lütfen 1 - 10 arasında bir değer giriniz. ");
            string gelenDeger = Console.ReadLine();

            int sayi1 = int.Parse(gelenDeger);
            //int sayi2 = Convert.ToInt32;
            int toplam = sayi1 + 15;

            Console.WriteLine("Toplam değer: {0}", toplam);

            Console.ReadLine();
        }
    }
}
