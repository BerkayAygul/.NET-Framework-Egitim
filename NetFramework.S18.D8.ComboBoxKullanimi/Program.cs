using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D8.ComboBoxKullanimi
{
    static class Program
    {
        /*
            -   ComboBox degerlerini obje olarak alir.

            -   ComboBox iki farkli sekilde doldurulabilir:
                1- ComboBox Itemlarini .Items.Add() metotu ile tek tek doldurmak. 
                2- ComboBox'un .DataSource Propertysi'ni kullanarak farkli bir kaynaktan Itemlari doldurmak.

            1:
            -   Nesne icerisinde sanal bir metot olan ToString() metotu Override edilmezse ComboBox'da ilgili
                nesnenin namespace.class adi gorulur.

            -   Urun Class'i icerisinde ToString() metotu return UrunAdi seklinde cozulebilir.

            -   Eger ComboBox icerisinde mevcut bir Data var ise ve mevcut Data uzerine farkli bir Data blogu ile
                Data eklenmek isteniliyorsa .Items.Add() metotu kullanilabilir.

            2:
            -   .DataSource = Database.UrunTablo ile verinin kaynagi girilir.
        
            -   Data goruntulenirken gene ToString() metotu Override edilmelidir.
                

            -   Urun listesinde her urunun kendi Index'i vardir ve farkli urunler secildiginde o urunun Index
                numarasi secili durumdadir.

            -   ComboBox > Properties > Events > SelectedIndexChanged  

            -   ComboBox'a erismenin 2 yolu vardir:
                1-  .SelectedItem ile obje olarak elde edilinebilir.
                   
                    object O1 = cmbBoxUrunListesi.SelectedItem;
                    urun U1 = (urun) O1;
                    
                    veya
                    
                    Urun U1 = cmbBoxUrunListesi.SelectedItem == null ? null: cmbBoxUrunListesi.SelectedItem as Urun;

                -   Eger Form icerisinde bulunan form elemanina ozel bir Metot yazilmissa o zaman
                    ilgili Form elemanini direk olarak cagirmak daha mantiklidir.

                -   Object Sender demek kullanici hangi Form elemaniyla islem yaptiysa ilgili Form elemani
                    Sender uzerinden gelir.

            

                2-  sender as ComboBox ile elde edilebilir.

                    ComboBox SecilenComboBox = sender as ComboBox;
                    
                -   Calisma zamaninda olusturulan Form elemanlarindan hangisine tiklandigi veya islem yapildigi
                    bilinmiyorsa ve Metot birden fazla Form elemaninda olay metotu olarak tanimlaniyorsa
                    Sender uzerinden gelen nesne kullanilir ve kullanicinin hangi Form elemaninda islem yaptigi
                    anlasilir.

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
