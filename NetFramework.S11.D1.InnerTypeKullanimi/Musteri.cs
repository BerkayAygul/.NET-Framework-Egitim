using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S11.D1.InnerTypeKullanimi
{
    public class Musteri
    {
        public int MusteriID;
        public string TCKimlikNo;
        public string Isim;
        public string SoyIsim;
        public int KullaniciID;

        public DateTime OlusturmaTarihi;

        public MusteriAdres[] MusteriAdresArray;
        public MusteriIletisim[] MusteriIletisimArray;
        public MusteriSiparis[] MusteriSiparisArray;

        public Musteri() // Yapici  metot
        {
            MusteriAdresArray = new MusteriAdres[5];
            MusteriIletisimArray = new MusteriIletisim[5];
            MusteriSiparisArray = new MusteriSiparis[51];
        }

    }
}
