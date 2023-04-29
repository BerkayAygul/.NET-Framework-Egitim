using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D3.ForOrnek3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Kullanicinin girişine göre faktöriyel hesabı


            string kullaniciDegeri = string.Empty;
            int kullaniciParse = 0;
            int sayac = 0;
            int faktoriyel = 1;
            
            Console.WriteLine("Bir doğal sayı giriniz: ");
            kullaniciDegeri = Console.ReadLine();

            kullaniciParse = int.Parse(kullaniciDegeri);

            for(sayac=kullaniciParse; sayac>1; sayac--)
            {
                faktoriyel = faktoriyel * sayac;
              
            }
            Console.Write("{0} degerinin sonucu = {1}", kullaniciParse, faktoriyel);
            Console.ReadLine();
            #endregion
        }
    }
}
