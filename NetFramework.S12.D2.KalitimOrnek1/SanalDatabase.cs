using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D2.KalitimOrnek1
{
    public static class SanalDatabase
    {
        private static ArrayList DataBaseListe = new ArrayList();

        public static void YeniUrunEkle(BaseClass data)
        {
            if(data != null && !string.IsNullOrEmpty(data.BarkodProperty))
            {
                DataBaseListe.Add(data);
            }
        }

        public static bool DataBaseBarkodKontrol(string Barkod)
        {
            bool KontrolIslem = false;
            if(DataBaseListe != null && DataBaseListe.Count > 0)
            {
                for(int i = 0; i<DataBaseListe.Count; i++)
                {
                    BaseClass BC = (BaseClass)DataBaseListe[i];
                    if(BC.BarkodProperty == Barkod)
                    {
                        KontrolIslem = true;
                    }
                }
            }
            return KontrolIslem;
        }
    }
}
