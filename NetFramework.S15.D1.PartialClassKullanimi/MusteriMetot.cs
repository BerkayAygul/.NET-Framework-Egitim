using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S15.D1.PartialClassKullanimi
{
    public partial class Musteri
    {
        public int YeniKayit(Musteri m1)
        {
            Console.WriteLine("Kayit islemi basarili");
            return 1;
        }

        public int KayitGuncelle(Musteri m1)
        {
            Console.WriteLine("Kayit guncelleme basarili");
            return 1;
        }

        public int KayitSil(int id)
        {
            Console.WriteLine("Kayit silindi");
            return 1;
        }
    }
}
