using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.S12.D2.KalitimOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar B1 = new Bilgisayar();

            //B1.ID = 1; Girilmeyecek, uygulama kapsulleme yaparken set ettirmeyecek.
            B1.Marka = "Lenova";
            B1.Model = "z50";
            B1.Islemci = "I5";
            B1.AlisFiyatiProperty = 1500M;
            B1.SatisFiyatiProperty = 2000M;
            B1.KampanyaFiyatiProperty = 1800M;
            B1.BarkodProperty = "123456789"; //

            SanalDatabase.YeniUrunEkle(B1);

            Bilgisayar B2 = new Bilgisayar();

            B2.Marka = "Lenova";
            B2.Model = "z50";
            B2.Islemci = "I5";
            B2.AlisFiyatiProperty = 1500M;
            B2.SatisFiyatiProperty = 2000M;
            B2.KampanyaFiyatiProperty = 1800M;
            B2.BarkodProperty = "123456789"; //Hata vermesi beklenir


            Console.ReadLine();
        }
    }
}
