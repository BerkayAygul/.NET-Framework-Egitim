using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S3.D1.IfElseKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
           int sayi1 = 10;
           int sayi2 = 15;

            bool sonuc = sayi1 < sayi2;



            #region 1. Kullanım

            if (sonuc)
            {
                Console.WriteLine("sayi1 < sayi2");
            }

            else
            {
                Console.WriteLine("sayi2 < sayi1");

            }

            #endregion

            #region 2. Kullanım

            if (sayi1<sayi2)
            {
                Console.WriteLine("sayi1 < sayi2");
            }
            else
            {
                Console.WriteLine("sayi2 < sayi1");

            }

            #endregion


            #region 3. Kullanim (Sadece Tekli Komutlar İçin Geçerli)

            if(sayi1<sayi2) Console.WriteLine("sayi1 < sayi2");
            else Console.WriteLine("sayi2 < sayi1");
            #endregion

            Console.ReadLine();
        }
    }
}
