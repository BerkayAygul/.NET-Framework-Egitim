using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S14.D2.InterfaceKullanimi
{
    public class Musteri : Imusteri
    {
        int IDF;
        string IsimF;
        string SoyIsimF;
        public int ID { get { return IDF; } set { IDF = value; } }
        public string Isim { get { return IsimF; } set { IsimF = value; } }
        public string SoyIsim { get { return SoyIsimF; } set { SoyIsimF = value; } }

        public int KayitDuzenle(int ID, string Isim, string SoyIsim)
        {
            Console.WriteLine("Kayit Duzenlendi");
            return 1;
        }

        public int KayitSil(int ID)
        {
            Console.WriteLine("Kayit Silindi");
            return 1;
        }

        public int YeniKayit(string Isim, string SoyIsim)
        {
            Console.WriteLine("Yeni Kayit Eklendi");
            return 1;
        }

        
    }
}
