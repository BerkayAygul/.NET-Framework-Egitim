using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D1.WindowsFormsKullanimi
{
    static class Program
    {
        /*
            -   Windows Forms, .exe ve setup uygulamalari yapmayı ve bu uygulamalari clientlara
                kurulmasını ve calistirilmasini saglar.

            -   App.config dosyasi yapilacak calismalarin standart olarak bazi degelerini .xml formatinda
                saklar ve uygulamanin .exe'si icerisine girmeden bazi degerleri duzeltilmesini saglar.
                
            -   Main metotu icerisindeki ilk metotlar Windows Form'un calismasi icin gerekli 
                sistem metotlarini barindirir.
               
            -   Application.Run yeni bir Form1 Class'i olusturur ve Form'un ekrana gelmesini tetikler.
                
            -   Form'un nesne ornegine gidildiginde Windows Forms'un kodlanan tarafi gorulur.

            -   Yapilacak yeni Form classi kutuphanede standart olarak bulunan Form classindan kalitilir.
                (YeniForm1 : Form).

            -   Class kendi yapisinda Partial ifadesini barindirir. Class'in bir kismi Form uygulamasinin
                gorunen kismidir, diger kismi ise dizayn kismidir.

            -   Class'in yapici metotu vardir. Form uygulamasi orneklendiginde InitializeComponent()
                adinda bir metot calisir. Bu metot, Form olusurken icerisine eklemis oldugumuz
                Form elemanlarini eklemeyi saglar.
        
            -   Ornegin, bir buton Form uygulamasina eklenirken bunun bir nesne ornegini sistem 
                System.Windows.Forms.Button() biciminde alir. Daha sonra ilgili Buton'un 
                konumu, ismi, boyutu, arkaplan rengi... gibi ozellikler eklenir. 

            -   Bir Form'a Buton eklenip cift tiklandigi zaman "Click" olayi gerceklestiginde olacaklar
                metodun icerisine yazilabilir.

            -   Ikinci bir form uygulamasi acildiktan sonra ikinci Form, birinci Form'un click
                butonu icin class olarak olusturulabilir.

            -   Form2 YeniForm = new Form2(); ile yeni Form orneklenir. Form orneklenirken yapici metot
                calisir. Yapici metot InitializeComponent() metotunu calistirir.
                InitializeComponent() ise form elemenlarini olusturur ve istenen diger olaylari
                gerceklestirir.

            -   Form orneklendigi zaman RAM uzerinde olusur ve kullanilmayi bekler.

            -   Form2.Show() metotu ile Form1'de bulunan butona basildigi zaman
                Form2 goruntulenebilir. 

            -   Form1'de yazilan metni yakalayip Form2'de gozukmesini saglamak icin ilk once Form1'e 
                Label ve TextBox eklenir.
        
            -   Eger TextBox'un icerisine Properties kismindan Text eklenirse deger
                InitializeComponent() icerisinde yazar.

            -   Alternatif olarak Form1'in class'ina gidildigi zaman InitializeComponent()'in altina
                Mesaj1.Text = "" ifadesi kullanilarak da yazilabilir.

            -   Mesaj1.Text ifadesi bir String degiskene atanir. Bu String degisken Form2'ye
                yapici metot ile aktarilir. Form2'nin Text degerine alinan deger atanir.

            -   Properties > Events kismindan gerceklesen olaylar kontrol edilebilir.

            -   Form1 icindeki TextBox'un gerceklesen olaylarina mudahale edilebilir.
            
            -   Ornegin, "Enter" Event'i TextBox'un uzerine imlec ile tiklanildigi zaman calisir.
                TextBox'un icerisindeki ifade guncellenmek isterse bu Event kullanilabilir.

            -   Form1'in uzerinden gelen TextBox yeni bir tanim yapilarak alinir.
                Daha sonra TextBox'un degerine baska bir ifade atanilabilir..

        */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
