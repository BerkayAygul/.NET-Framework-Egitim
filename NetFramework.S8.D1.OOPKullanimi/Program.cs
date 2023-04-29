﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S8.D1.OOPKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();     

            M1.TCkimliknumara = "1";
            M1.isim = "Doom";
            M1.soyisim = "Guy";
            M1.cinsiyet = 2000;

            Musteri M2 = M1;

            M2.isim = "Daisy";
            M1.TCkimliknumara = "2";

            M2 = null;
            M1 = null;

            string isim = M2.isim;
        }
    }
}
