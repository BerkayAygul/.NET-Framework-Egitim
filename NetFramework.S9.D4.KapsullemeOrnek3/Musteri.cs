using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D4.KapsullemeOrnek3
{
    class Musteri
    {
        public string isim;
        private string soyisim;      //Field
        public string emailAdres;

        public string Soyisim       //Property
        {
            set
            {
                this.soyisim = value;
                this.emailAdres = string.Format("{0}.{1}@hotmail.com", isim, soyisim);
            }
            get
            {
                return this.soyisim;
            }
        }
    }
}
