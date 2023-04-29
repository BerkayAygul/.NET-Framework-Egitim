using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D6.FormKontrolleri
{
    public class SanalDatabase
    {
        public static List<Kullanici> Kullanicilar { get; set; }

        static SanalDatabase()
        {
            Kullanicilar = new List<Kullanici>();
        }

    }
}
