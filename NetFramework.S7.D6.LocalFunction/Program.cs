﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D6.LocalFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalFunctionKullanimi(12, 22);
        }


        static void LocalFunctionKullanimi(int sayi1, int sayi2)
        {
            int topla(int gelenSayi1 , int gelenSayi2)

                {
                    return gelenSayi1 + gelenSayi2;
                }

            int toplamDeger = topla(sayi1 , sayi2);
            Console.WriteLine(toplamDeger);
        }
    }
}
