using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D2.KullaniciGirisiUygulama
{
    public class SanalDatabase
    {
        public static List<Kullanici> KullaniciTablo = new List<Kullanici>();

        static SanalDatabase()
        {
            KullaniciTablo.Add(new Kullanici()
            {
                ID = 1,
                Isim = "Gottfried",
                SoyIsim = "Leibniz",
                KullaniciAdi = "gottfried.leibniz",
                Sifre = "123",
                Aciklama = "Aciklamanizi Buraya Giriniz"
            });

            KullaniciTablo.Add(new Kullanici()
            {
                ID = 2,
                Isim = "Carl Friedrich",
                SoyIsim = "Gauss",
                KullaniciAdi = "carlfriedrich.gauss",
                Sifre = "123",
                Aciklama = "Aciklamanizi Buraya Giriniz"
            });
            
        }
    }
}
