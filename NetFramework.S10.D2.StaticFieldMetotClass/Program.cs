using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D2.StaticFieldMetotClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel P1 = new Personel();
            P1.isim = "Magister";
            P1.soyIsim = "Sibrandus";
            P1.emailAdres = "magister.sibrandus";
            P1.cinsiyet = 11921190;

            Personel P2 = new Personel(); // Nesne ornegi tekrar alindigi icin standart CTOR tekrar calisir
            P2.isim = "Magister"; // Nesne ornegi alinmadan ilk once static metot calisir
            P2.soyIsim = "Sibrandus";
            P2.emailAdres = "magister.sibrandus";
            P2.cinsiyet = 11921190;

            // Helper H1 = new Helper(); Static class oldugu icin nesne ornegi alinamaz

            Helper.EmailGonder("magistermilitum@spqr.com", "Yeni Personel Bilgilendirme", P1.isim + P1.soyIsim);

            Console.ReadLine();


        }
    }
}
