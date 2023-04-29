using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D6.FormKontrolleri
{
    static class Program
    {
        /*
            -   Form elemanlari olusturuldugunda arkada calisan islemler elemelanlarin Classlarinda incelenir.

            -   Olusturulan Form1, Form nesnesinden kalitilarak olusur.

            -   InitializeComponent() metotuna gidildigi zaman kontroller gorulebilir.

            -   this.button1, this.textBox1, this.label1... = new System.Windows.Forms.Button(), new System...
                seklinde form elemanlari new ile orneklenir.

            -   Herhangi bir elemanin Defination'una gidildiginde miras aldigi class ve interface gorulur.
                Button1 : ButtonBase, IButtonControl

            -   ButtonBase classi ise kendisini Control sinifindan kalitir.
                ButtonBase:Control

            -   Control classi ise bir cok interface ile kalitilir.

            -   Kalitimlar incelendiginde bir sure sonra kalitim kesilir ve objeye geri donulur.

            -   Butun Windows Forms elemanlari en temelde Control nesnesinden turetilir ve Form'un icerisine
                atildiklarinda Controls adinda bir koleksiyona kendilerini kayit ederler.

            -   Bir Button olusturuldugu zaman Controls koleksiyonuna .add() metotu ile eklenilecektir.
             
            -   Eklenildigi zaman Windows Form elemaninin tipi Control tipine geri donecektir.

            -   Kalitilan nesne ana nesnenin sekline burunur ve o sekilde kalir (Boxing).
            
            -   Form'un uzerine bir eleman eklenildigi zaman bu Form'un Controls koleksiyonuna Control tipinde
                eklenir ve uygulama uzerinde ulasilmak istenildiginde bu elemana Control tipinde ulasilir.

            -   foreach(Control item in this.Controls)
                {
                    MessageBox.Show(item.Name);   
                }

                Dongusu yapildigi zaman Form'a eklenen elemanlar gorulebilir. Bu elemanlar Control tipinde cekilir.

            -   foreach(Control item in this.Controls)
                {
                    if(item is TextBox)
                    {
                        Textbox T1 = (TextBox)item;
                        T1.Text = string.empty;
                    }
                }
                
                Dongusu ile Textbox orneklenir ve Control nesnesinden TextBox'a Unboxing islemi yapilir.
                Daha sonra Form'un icerisindeki tum TextBoxlarin degerlerinin silinmesi saglanir.

            -   Alternatif olarak elemanlarin Indexleri kullanilarak da islemler yapilabilir.
                Index olarak elemanlarin isimleri kullanilir.

                private void FormElemanIndexTemizle()
                {
                    ((TextBox)this.Controls["txtIsim"]).Text = string.Empty;
                    ((TextBox)this.Controls["txtSoyIsim"]).Text = string.Empty;
                    ((TextBox)this.Controls["txtEmailAdres"]).Text = string.Empty;
                    ((TextBox)this.Controls["txtTelefonNo"]).Text = string.Empty;
                }

            -   Bir formdan bir forma bilgi aktarmak icin elemanlarin Indexleri kullanilabilir.

            -   Application nesnesi icerisinde 

            -   foreach (Form item in Application.OpenForms)
                {
                MessageBox.Show(item.Name);
                }

                Dongusu ile acik olan formlar yakalanir.

            -   foreach (Form item in Application.OpenForms)
                {
                    if(item.Name == "Form1")
                    {
                        foreach (Control FormItem in item.Controls)
                        {
                            if(FormItem is TextBox)
                            {
                                ((TextBox)FormItem).Text = string.Empty;
                            }
                        }
                    }
                }

                Dongusu ile acik olan formlar aranip istenilen forma ulasildiginda icinde
                istenilen elemanlar silinebilir.

            -   Form YakalananForm = Application.OpenForms["Form1"]
                YakalananForm.Controls["txtIsim"] ile de index uzerinde islem yapilabilir.
  
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
