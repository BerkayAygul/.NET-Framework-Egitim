using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S17.D3.GenericClassKullanimi
{
    public class MusteriGeneric<T>
    {
        public T ID { get; set; }
        public T MusteriNumarasi { get; set; }
        public string TCKimlikNo { get; set; }

        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public DateTime DogumTarihi { get; set; }
        

        public T MusteriNumarasiAl()
        {
            return MusteriNumarasi;
        }
    }
}
