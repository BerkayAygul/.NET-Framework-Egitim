using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D4.MessageBoxNotificationKontrolleri
{
    public static class SanalDatabase
    {
        public static List<Musteri> Musteriler { get; set; }


        static SanalDatabase()
        {
            Musteriler = new List<Musteri>();
        }
        

    }
}
