using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D94.DoWhileOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Kullaniciyi do while döngüsünde, kullanici adi: Demo ve Şifre: 123 Sor. Giriş yapılırsa başarılı yaz. Yoksa Döngüden devam et.

            string kullaniciAd = string.Empty;
            string sifre = string.Empty;

            do
            {
                Console.Write("\nKullanici Adınızı Giriniz: ");
                kullaniciAd = Console.ReadLine();

                Console.Write("\nŞifrenizi Giriniz: ");
                sifre = Console.ReadLine();

            } while (kullaniciAd.ToLower() != "demo" || sifre != "123");

            Console.WriteLine("\nGiriş Başarılı");

            Console.ReadLine();
            #endregion
        }
    }
}
