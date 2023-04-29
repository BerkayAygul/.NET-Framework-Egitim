using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D1.MetotGenelKullanimi
{
    public class Ogrenci
    {
        public void selamlaOgrenci()
        {
            Console.WriteLine("Merhaba Ögrenci");
        }
        private void OgrenciMetod1(string ogrenciAdi, string ogrenciSoyadi)

        {
            Console.WriteLine("Ögrenci Bilgileri = {0} {1}", ogrenciAdi, ogrenciSoyadi);
        }

        public void OgrenciMetod2()
        {
            OgrenciMetod1("Duke", "Nukem");
        }
    }
}
