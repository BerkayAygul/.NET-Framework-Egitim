using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S11.D1.InnerTypeKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                - Iliskisel veritabani modellerini uygulama katmaninda ornekleyebilmek,
                  datayi daha dogru ve daha okunabilir sekilde tek bir class icerisinde
                  toplamak icin kullanilir.

                - Ornegin, bir musterinin bir cok farkli ozelligini
                  database tarafinda iliskisel tablo duzeyinde daginik bir sekilde
                  tutulur. C#'da daginik olan nesneleri tek bir nesnenin icerisinde
                  toparlayarak datayi bir butun olarak elde ederiz.
            */

            Musteri M1 = new Musteri()
            {
                MusteriID = 1,
                TCKimlikNo = "11111111111",
                Isim = "William",
                SoyIsim = "Wallace",
                OlusturmaTarihi = DateTime.Now
            };

            //M1.musteriAdresArray = new MusteriAdres[4] burada yapilmaz, musteri.cs de yapilir
            //Array orneklenmezse hata alinir, baslangic degeri nulldur

            M1.MusteriAdresArray[0] = new MusteriAdres()
            {
                Il = "Renfrewshire",
                Ilce = "Elderslie",
                Adres = "....",
                AdresinTipi = "Ev"
            };

            M1.MusteriAdresArray[0].MusteriAdresMetot(); //Index bos olursa hata olusur

            M1.MusteriSiparisArray[0] = new MusteriSiparis()
            {
                SiparisNumarasi = "SIP000001",
            };

            M1.MusteriSiparisArray[0].UrunArray[0] = new Urun()
            {
                UrunID = 1,
                Tanim = "Bilgisayar",
                Fiyat = 20000
            };
        }
    }
}
