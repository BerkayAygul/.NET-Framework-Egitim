using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D2.SanalMetotOrnek1
{
    public class Urun:BaseClass
    {
        public Urun()
        {
            Console.WriteLine("Urun Class yapici metot");
        }
        public override void EkranaYazdirVirtual(string data)
        {
            Console.WriteLine("Sanal metot Urun sınıfında overridelandi");
        }
    }   
}
