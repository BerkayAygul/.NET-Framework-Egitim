using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S5.D1.DiziKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenciIsimListesi = new string[5];

            ogrenciIsimListesi[0] = "Isim1";
            ogrenciIsimListesi[1] = "Isim2";
            ogrenciIsimListesi[2] = "Isim3";
            ogrenciIsimListesi[3] = "Isim4";
            ogrenciIsimListesi[4] = "Isim5";

            foreach (string item in ogrenciIsimListesi)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            for (int i=0; i <ogrenciIsimListesi.Length; i++)
            {
                string IsimYazdir = ogrenciIsimListesi[i];
                Console.WriteLine(IsimYazdir);
            }
            Console.ReadLine();
        }
    }
}
