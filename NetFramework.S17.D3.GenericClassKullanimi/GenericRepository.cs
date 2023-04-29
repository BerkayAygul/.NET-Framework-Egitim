using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S17.D3.GenericClassKullanimi
{
    public class GenericRepository<T> //where T:class
    {
        public GenericRepository()
        {
            // Context : Entity Framework DBFirst
        }

        public virtual List<T> Getir()
        {
            /* 
               Gelen T tipini database uzerinden sorgulamak ve elde edilen kayitlari Generic Koleksiyon
               olarak bir ust katmana gondermek
            */ 

            return null;
        }

        public virtual void YeniKayitEkle(T Data)
        {
            // Gelen T tipi icerisindeki bilgiyi T tipinin isaret etmis oldugu tabloya ekle

        }
    }
}
