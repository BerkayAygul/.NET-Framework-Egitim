using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S16.D1.EnumKullanimi
{
    public class SanalDatabase
    {
        ArrayList DBList = new ArrayList();

        public MusteriReturnValue MusteriYeniKayit(Musteri MusteriVeri)
        {
            DBList.Add(MusteriVeri);
            return MusteriReturnValue.KayitBasarili;
        }
    }
}
