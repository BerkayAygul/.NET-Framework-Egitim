using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S8.D2.SınıflardaMetotlarınKullanimi
{
    class Musteri
    {
        public string TCkimliknumara;
        public string isim;
        public string soyisim;
        public int cinsiyet;

        public bool MusteriKontrol()
        {
            bool kontrol = MusteriKontrolDatabase(TCkimliknumara);
            return kontrol;
        }

        private bool MusteriKontrolDatabase(string tckimliknumarasi)
        {
            //Database gidilir, müşterinin tc kimlik numarasina göre daha önce kayit edilip edilmediği bilgisini verir.
            return true;
        }
    }
}
