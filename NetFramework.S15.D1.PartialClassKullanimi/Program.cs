using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S15.D1.PartialClassKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
        /*
            -   Bilinmesi iyi olan ama kullanimi zorunlu olmayan bir konudur

            -   Bir uygulama yazarken birden fazla baglanti kuruldugunda cok fazla kod blogu
                olusur. Bulmak istedigimiz classi aramak zorunda kalabiliriz (CTRL+F).
                Bu kodda duzensizlige yol acar. 

            -   Bir classin fieldlerini bir tarafa, metotlarini farkli bir tarafa toplamak,
                Fieldlara veya metotlara bakmak istenince ilgili bolumdeki alana 
                bakip fieldlari veya metotlari arayabilmek ve eklemek icin, uygulama
                calistiginda ve ilgili classa ulasildiginda ise iki farkli parcayi
                tek bir parca olarak elde edebilmek icin partial classlar kullanilir.

            -   Ornegin Musteri classini parcalara ayirmak icin:
                1- MusteriField.cs acilir
                2- MusteriMetot.cs acilir
                3- Bu classlarin namespaceleri sadece Musteri kalacak sekilde silinir
                4- Partial keywordu public partial class Musteri seklinde eklenir

        */

            Musteri M1 = new Musteri();

            M1.ID = 1;
            M1.Isim = "Erich";
            M1.SoyIsim = "Ludendorff";
            M1.EmailAdres = "Erich.Ludendorff@hotmail.com";

            int sonuc = M1.YeniKayit(M1);

            if (sonuc > 0)
            {
                Console.WriteLine("Database kayit eklendi");
            }
        }
    }
}
