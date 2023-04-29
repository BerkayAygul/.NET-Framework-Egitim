using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D4.MessageBoxNotificationKontrolleri
{
    public class Musteri
    {
        public Guid ID { get; set; }
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public string EmailAdres { get; set; }
        public string TelefonNo { get; set; }

        public override string ToString()
        {
            return Isim + " " + SoyIsim;
        }
    }
}
