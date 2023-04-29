using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NetFramework.S7.D2.MetotOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Matematik M = new Matematik();
            decimal sonuc = 0;

            Console.Clear();

            Console.Write("1. Sayiyi Seçiniz: ");
            decimal kullaniciSayi1 = decimal.Parse(Console.ReadLine());

            Console.Write("\n2. Sayiyi Seçiniz: ");
            decimal kullaniciSayi2 = decimal.Parse(Console.ReadLine());
        
            MenuyeDon:

            M.Menü();

            int kullaniciSecim = int.Parse(Console.ReadLine());



            switch (kullaniciSecim)

             
            {
                case 1:
                    sonuc = M.ToplamaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.EkranaYazdir(kullaniciSayi1, "+", kullaniciSayi2, sonuc);
                    break;

                case 2:
                    sonuc = M.CikartmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.EkranaYazdir(kullaniciSayi1, "-" , kullaniciSayi2, sonuc);
                    break;

                case 3:
                    sonuc = M.CarpmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.EkranaYazdir(kullaniciSayi1, "*" , kullaniciSayi2, sonuc);
                    break;
                case 4:
                    sonuc = M.BolmeIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.EkranaYazdir(kullaniciSayi1, "/", kullaniciSayi2, sonuc);
                    break;
                default:
                    Console.WriteLine("Seçeneneklerden Birisini Seçmediniz. Menüye Dönülüyor");   
                    System.Threading.Thread.Sleep(2500);
                    Console.Clear();
                    Console.WriteLine("1. Sayi = {0} \n2. Sayi = {1}", kullaniciSayi1, kullaniciSayi2);
                    goto MenuyeDon;
                    
            }
            YanlisHarf:

            Console.Write("\nYeni Islem Yapmak Istiyor Musunuz? [E/H]: ");
            string yeniden = Console.ReadLine();

            if(yeniden.ToLower() == "e")
            {
                goto MenuyeDon;
            }
            else if (yeniden.ToLower() == "h")
            {

            }
            else
            {
                Console.WriteLine("\n\nE/H!");
                goto YanlisHarf;
            }

        } 
    }
}
