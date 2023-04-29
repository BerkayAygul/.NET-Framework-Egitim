using System;
using System.Collections;
using System.Security.Cryptography;
using System.Threading;

namespace NetFramework.S6.D3.HashTableKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable H1 = new Hashtable();

            H1.Add("Key", "Value");
            H1.Add("Car", "Araba");       // Key Özgün Olmak Zorundadır.
            H1.Add("House", "Ev");

            bool kontrol1 = H1.Contains("Value"); // Key Kontrol Eder
            bool kontrol2 = H1.Contains("Key");
            bool kontrol3 = H1.ContainsKey("Car");
            bool kontrol4 = H1.ContainsValue("Araba");

            int hashTableIçerisindekiDegerler = H1.Count;

            H1.Add("Sil1", "Sil2");
            H1.Remove("Sil2"); // Sadece Key Siler
            H1.Remove("Sil1");


            H1["House"] = "Villa";


        }
    }
}
