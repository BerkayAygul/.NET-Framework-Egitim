using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D1.KalitimKullanimi
{
    public class TemelTip
    {
        public int ID { get; set; }
        public string ReferansKod  { get; set; }
        public string TCKimlikNo { get; set; }
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public int Cinsiyet { get; set; }
        public DateTime KayitTarihi { get; set; }
        public int KayitKullanici { get; set; }
        public DateTime GuncellemeTarih { get; set; }
        public int GuncellemeKullanici { get; set; }
        public bool SilindiSilinmedi { get; set; }

        public TemelTip()
        {
            Console.WriteLine("Temel tip nesnesinin yapici metotu calisti");
            IDAtamaIslemi();
        }

        private void IDAtamaIslemi()
        {
            Random rnd = new Random();
            this.ID = rnd.Next(1000, 9000);
        }

        public void TemelTipMetot1()
        {
            Console.WriteLine("Temel Tip => Public Metot1");
        }

        protected void TemelTipMetot2()
        {
            Console.WriteLine("Temel Tip => Protected Metot2");
        }

    }
}
