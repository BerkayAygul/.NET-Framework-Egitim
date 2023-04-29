using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D2.KapsullemeOrnek1
{
    public class Musteri
    {
        public Musteri() // Yapıcı metot çalışcak ve çalışırken private olarak saklanan fielda değer ata
        {
            this.id = idUretMetot();
        }
        // Program.cs'de class uretildigi andan sonra ilk olarak yapıcı metota uğranılır

        public string isim;
        public string soyisim;


        #region ID

        private int id; // id Field
        public int ID // ID property
        { 
                    get { return this.id; }  // Private olarak saklanan değeri al ve id'yi return et, değeri okut
            private set { } // Set'in tek amacı program.cs de propertye değer atanirsa bunu fielda atar
        }                                    // Set Private yapılırsa değer atanamaz ama değer okunur

        private int idUretMetot () 
        {
            Random rnd = new Random();
            return rnd.Next(10000, 20000);
        }

        #endregion


        #region email
        private string emailAdres;
        public string EmailAdres
        {
            // get = Database veya farklı bir veri kaynağından ... class çağıran programcıya datayı gösterdiğimiz kısım
            // set = Dış dünyadan alınan datanın içeride private olarak saklanan field içerisine değer atadığı kısım

            set
            {
                this.emailAdres = value;
            }
            get
            {
                return this.emailAdres;
            }

        }
        #endregion

    }
}
