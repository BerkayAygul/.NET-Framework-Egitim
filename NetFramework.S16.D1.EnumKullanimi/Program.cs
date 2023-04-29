using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S16.D1.EnumKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                -   Uygulamayi yazan yazilimciya ve yazilimi okuyacak sonraki yazilimcilara 
                    okuma kolayligi saglar.

                -   Yazilimi surekli debug ederek anlamaya calismaktan kurtarir.

                -   Yeni bir class acilip class ifadesi enum ile degistirilir.
                
                -   Kontrol ifadelerini sayilar ile kontrol etmeye yarar
                   
                
            */

            Musteri M1 = new Musteri();

            M1.ID = 1;
            M1.MusteriNo = "CCNN0001";
            M1.Isim = "Italo";
            M1.SoyIsim = "Balbo";
            M1.EmailAdres = "regiaaeronautica@hotmail.com";

            SanalDatabase SB = new SanalDatabase();

            MusteriReturnValue MusteriKayitSonuc = SB.MusteriYeniKayit(M1);

            if (MusteriKayitSonuc == MusteriReturnValue.KayitBasarili)
            {

            }

        }
    }
}
