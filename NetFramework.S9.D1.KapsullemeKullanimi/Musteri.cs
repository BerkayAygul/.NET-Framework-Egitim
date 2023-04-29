using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D1.KapsullemeKullanimi
{
   public class Musteri
    {
        //Class => Field

        public int id;
        public string isim;
        public string soyisim;

        private string emailAdres;

        //Class => Property

        public string EmailAdres
        {
            // get = Database veya farklı bir veri kaynağından ... class çağıran programcıya datayı gösterdiğimiz kısım
            // set = Dış dünyadan alınan datanın içeride private olarak saklanan field içerisine değer atadığı kısım

            set
            {
                this.emailAdres = value; // Value içindeki değeri private olarak saklanan field içine at
            }
            get
            {
                return this.emailAdres; // Fieldin içindeki değeri property yardımıyla onu çağıran kişiye göster
            }

        }
    }
}
