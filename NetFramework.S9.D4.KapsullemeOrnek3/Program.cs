using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D4.KapsullemeOrnek3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1- İsim ve Soyisim Ata
               2- Bu değerler arka planda bir e-mail adresi oluşturacak
               3- get ederken william.wallace@hotmail.com
               4- set ederken private olacak.
            */

            Musteri M1 = new Musteri();

            M1.isim = "William";
            M1.Soyisim = "Wallace";

            Console.WriteLine("Email Adres = {0}", M1.emailAdres);
        }
    }
}
