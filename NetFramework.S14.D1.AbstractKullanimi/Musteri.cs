using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S14.D1.AbstractKullanimi
{
    public class Musteri:BaseClass
    {
        public int MusteriID { get; set; }

        public Musteri()
        {
            MusteriID = 1;
        }

        public override void TestAbstract()
        {
            Console.WriteLine("Musteri > Abstract Class");
        }
    }
}
