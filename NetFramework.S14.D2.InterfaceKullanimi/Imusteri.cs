using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S14.D2.InterfaceKullanimi
{
    public interface Imusteri
    {
        int ID { get; set; }
        string Isim { get; set; }
        string SoyIsim { get; set; }

        int YeniKayit(string Isim, string SoyIsim);
        int KayitDuzenle(int ID, string Isim, string SoyIsim);
        int KayitSil(int ID);
    }
}
