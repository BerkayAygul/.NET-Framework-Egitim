using NetFramework.S10.D3.StaticOrnek1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D3.StaticBolumSonuOdevUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();

            M1.musteriID = 1;
            M1.isim = "Magister";
            M1.soyisim = "Sibrandus";
            M1.emailAdres = "magister.sibrandus@spqr.com";
            M1.KullaniciAdi = "magister.sibrandus";
            M1.sifre = "1";

            Musteri.MusteriEkle(M1);

            Musteri M2 = new Musteri()
            {
                musteriID = 2,
                isim = "Magister",
                soyisim = "Konrad",
                emailAdres = "Magister.Konrad@spqr.com",
                KullaniciAdi = "magister.konrad",
                sifre = "2"
            };

            Musteri.MusteriEkle(M2);

            Musteri M3 = new Musteri();
            M3.musteriID = 1;
            M3.isim = "Magister";
            M3.soyisim = "Sibrandus";
            M3.emailAdres = "magister.sibrandus@spqr.com";
            M3.KullaniciAdi = "magister.sibrandus";
            M3.sifre = "1";

            Musteri.MusteriEkle(M3);

            Console.ReadLine();
        }
    }
}
