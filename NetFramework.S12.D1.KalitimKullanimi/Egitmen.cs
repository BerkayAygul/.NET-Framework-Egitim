﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D1.KalitimKullanimi
{
    public sealed class Egitmen:Personel
    {
        public string Brans { get; set; }
        public int BransSeviye { get; set; }
        public Egitmen()
        {
            Console.WriteLine("Egitmen nesnesinin yapici metotu calisti");
        }
    }
}
