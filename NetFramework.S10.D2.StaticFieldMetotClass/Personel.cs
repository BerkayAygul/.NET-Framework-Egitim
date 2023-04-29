using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D2.StaticFieldMetotClass
{
    class Personel
    {
        public static string domainAdres;

        public string isim;
        public string soyIsim;
        public int cinsiyet;

        private string _emailAdres;
        public string emailAdres 
        {
            get 
            { 
                return this._emailAdres; 
            }
            set 
            {
                this._emailAdres = value.ToLower() + "@" + domainAdres;

            } 
        
        }

        static Personel()
        {
            domainAdres = "spqr.com";
        }

        public Personel()
        {
            Console.WriteLine("Personel > Public Class > Public CTOR");
        }




    }
}
