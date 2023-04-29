using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D2.KalitimOrnek1
{
    public class BaseClass
    {
        public static int sayac = 1; // Ilk olustugu zaman 1 degerini otomatik olarak alsin

        public BaseClass()
        {
            IDField = sayac;
            sayac = sayac + 1;
        }

        private int IDField; // Kontrol et
        private string BarkodField;
        public int IDProperty
        {
            get
            {
                return IDField;
            }
            private set //Sayac Degerinden Faydalan
            {
               /* IDField = sayac;
                sayac = sayac + 1;
                Calismaz, set alani private olarak isaretlenmistir. Ctor ile yapilir*/
            }
        
        }


        public string BarkodProperty 
        { 
            get
            {
                return this.BarkodField;
            }

            set
            {
                bool KontrolIslemi = SanalDatabase.DataBaseBarkodKontrol(value);
                
                if(!KontrolIslemi) // Deger sanal database icerisinde yok
                {
                    BarkodField = value;
                }
                else
                {
                    Console.WriteLine("Sanal database icerisinde bu barkot degeri daha once girilmistir");
                }
            }
        
        
        
        } // Kontrol et
        public DateTime OlusturmaTarihi { get; set; }
        public int OlusturanKullanici { get; set; }

        public DateTime GuncellemeTarihi { get; set; }

        public int GuncelleyenKullanici { get; set; }

        public bool SilindiSilinmediKontrol { get; set; }


    }
}
