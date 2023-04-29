using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S8.D3.SınıfOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            Arac A1 = new Arac("Opel", "Corsa", 2010, 56000);

            A1.AlisFiyat = 28000;
            A1.SatisFiyat = 32000;
            A1.MaxIndirimTutar = 1500;

            A1.FiyatAta(32000);


            A1.BilgileriGoruntule();
            
        }
    }
}
