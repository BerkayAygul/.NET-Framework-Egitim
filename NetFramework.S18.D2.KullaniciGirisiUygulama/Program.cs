using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D2.KullaniciGirisiUygulama
{
    static class Program
    {
        /*
            -   Form1 > Text              > Kullanici Giris
                Form1 > Start Position    > Center
                Form1 > Form Border Style > Fixed

            -   Form1 > Add Button     > Text = "Giris Yap"
                Form1 > Add TextBox    >
                Form1 > Add Label      > Text = "KullaniciAdi"
                Form1 > Add PictureBox > Resim Ekle

            -   Ctrl + Mouse kullanilarak var olan itemlerin kopyalari cikarilir.

            -   Sifreyi gizlemek icin Properties > UsePasswordChar > * kullanilir.

            -   View > Tab Order ile uygulama baslatildigi zaman Tab tusuna basilinca
                Kullanici Adi > Sifre > Giris sirasiyla hareket saglanilir.

            -   Alinan kullanici adi ve sifre degerleri If karar yapisi icerisinde kontrol edilip
                kullanicinin dogru bilgileri girmesiyle yeni bir Form'un acilmasi saglanir.
            
            -   Kullanici bilgileri yanlis girildiyse MessageBox.Show kullanilarak kullaniciya
                bir pop up gosterilir.
           
            -   Yeni bir Form acilir ve bir tane Label eklenir. Bu label kullanici adini alicak ve
                "Merhaba ...(Kullanici Adi)" mesajini gosterecek.

            -   Sanal Database classi olusturulur. Bu Sanal Database icerisinde bir Generic List tutulur.
                Icerisinde profiller barindiracak bu List sayesinde kullanici adi ve sifre dogrulamasi
                yapilir.

            -   Kullanici adinda bir class olusturulur ve Propertyler yazilir.

            -   Ilk once kullanici tablosu icerisinde kriterlere uyan kullanici olup olmadigini
                kontrol etmek icin .Find(i => i. KullaniciAdi == KullaniciAdi && i.Sifre == Sifre) 
                metotu ile arama yapilmalidir. Sonuc ise bir nesneye aktarilmalidir.

            -   Nesne ise Form2'ye aktarilir ve kullanici selamlanir.

            -   Yanlis kullanici girisi pop up ekranini daha duzenli hale getirmek icin
                Bir baslik, MessageBoxButtons.OK ve MessageBoxIcon.Error eklenir.

            -   TextBox > Event > Focus > Enter ile TextBox'a tiklandiginda calisacak olan metottur.
                Istenilirse degistirilebilir.TextBox T1 = (TextBox)sender ile TextBox olusturulur.
                T1.BackColor = Color.White gibi degisiklikler yapilabilir.

            -   Form2'ye yeni Label ve TextBoxlar eklenerek kullanicinin bilgileri atanir.

            -   KullaniciAdi.Enabled ozelligi false yapilarak kullanicinin bu bilgiyi guncellemesi
                engellenir.

            -   Button GuncelleYakala = (Button)sender islemini gerceklestirmek yerine
                Guncelle.Tag = BulunanKullanici.ID ile Tag degeri girilir.
                Kullanimi daha kolaydir.

            -   Kullanici Database'inde ID degeri aranir ve int bir degiskene atanir.

            -   Kullanici Database'inde Index degeri baz alinarak degerler kullanici tarafindan
                tekrar girilebilir.
        */

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
