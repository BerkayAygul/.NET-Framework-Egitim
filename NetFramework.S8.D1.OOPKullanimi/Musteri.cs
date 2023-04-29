using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S8.D1.OOPKullanimi
{
    public class Musteri
    {
        /* Yapıcı Metot - ctor     tab
        () = Default Değerler ile Oluştur
        Değer Alma Zorunluluğu Yapıcı Metotlar ile Sağlanır
        Değer Atanmaz ise Default Değerler Atar
        Kodlar Arka Tarafta Çalışırken Class'ın İçinde Duran ve Varlığını Koruyan Fieldlerin Veritiplerine Göre Default Değer Atar
        Default Değerler Atandıktan Sonra İşlem Yapılabilir Hale Gelirler. Sistem, Class'ı Kullanılabilir Yapar.
        
        Sistemin Default Değerlerini Değiştirmek için Yapıcı Metotlar Kullanılır
        Var Olan Yapıyı Ezerek Default Değerleri Değiştirirler
        */

        
        public Musteri()    /* 1. Kullanim */
        {
            TCkimliknumara = "100";
        }

        public Musteri(string _isim, string _soyisim) /* 2. Kullanim */
        {
            isim = _isim;
            soyisim = _soyisim;
        }

        /* Artık 2 Adet Overloadı var */

        public string TCkimliknumara;
        public string isim;
        public string soyisim;
        public int cinsiyet;
    }
}
