using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D8.ComboBoxKullanimi
{
    public class Urun
    {
        public int ID { get; set; }
        public string UrunAdi { get; set; }
        public string UrunKategorisi { get; set; }
        public int UrunStokAdedi { get; set; }
        public string Yazar { get; set; }
        public string UrunAciklamasi { get; set; }
        public string UrunResmi { get; set; }

        public override string ToString()
        {
            return UrunAdi;
        }

    }
}
