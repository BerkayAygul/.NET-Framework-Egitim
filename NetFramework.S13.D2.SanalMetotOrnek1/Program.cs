using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D2.SanalMetotOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass B1 = new BaseClass();
            Urun N1 = new Urun();
            Televizyon T1 = new Televizyon();
            
            N1.EkranaYazdir("Urun nesnesi icerisinden cagrilan, sanal olmayan metot");

            B1.EkranaYazdirVirtual("Baseclass nesnesi icerisinden cagrilan, sanal olan metot");

            N1.EkranaYazdirVirtual("Override");

            T1.EkranaYazdirVirtual("Televizyon urunden kalitilmis oldugundan dolayi override");

            Console.ReadLine();
        }
    }
}
