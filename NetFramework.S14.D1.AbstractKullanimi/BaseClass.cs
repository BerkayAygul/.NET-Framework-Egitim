using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S14.D1.AbstractKullanimi
{
    public abstract class BaseClass
    {
        public DateTime KayitTarih { get; set; }
        public DateTime GuncellemeTarih { get; set; }

        public BaseClass()
        {
            KayitTarih = DateTime.Now;
            GuncellemeTarih = DateTime.Now;
        }

        public void Test()
        {
            Console.WriteLine("Baseclass > Test Metot");
        }

        public abstract void TestAbstract(); // Metot imzasi
        //{
        //}
    }
}
