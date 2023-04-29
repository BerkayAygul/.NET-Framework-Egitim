using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D2.SanalMetotOrnek1
{
    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Base Class yapici metot");
        }
        public void EkranaYazdir(string data)
        {
            Console.WriteLine(data);
        }

        public virtual void EkranaYazdirVirtual(string data)
        {
            Console.WriteLine(data);
        }



    }
}
