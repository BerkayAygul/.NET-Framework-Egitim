using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S17.D3.GenericClassKullanimi
{
    public class Musteri
    {
        public int ID { get; set; }
        public Guid MusteriNumarasi { get; set; }
        public string TCKimlikNo { get; set; }
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public DateTime DogumTarihi { get; set; }


    }
}
