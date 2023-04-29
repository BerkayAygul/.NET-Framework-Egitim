using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D1.SanalMetotKullanimi
{
    public class Musteri
    {
        public int MusteriID { get; set; }
        public string Isim { get; set; }
        public string SoyIsim { get; set; }

        public override string ToString()
        {
            return Isim + " " + SoyIsim;
        }
    }
}
