using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D1.KalitimKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                - Kalitim yolu ile olusturulan nesneler birbirlerinten turetilebilir ve tureyen nesne
                  turetilen nesnenin tum ozelliklerini kullanabilir.

                - Object tipi framework icerisinde tum nesnelerin atasi oldugu icin
                  turetilen tip kendisinden tureyen tum tipleri tanir ve tam uyumluluk saglar.

                - Ogrenci O1 = new Ogrenci()
                  Yukarida nesne ornegi alinan ogrenci nesnesi aslinda object tipinden uretilmis bir nesnedir.

                - O1. yazildiktan sonra karsimiza bazi metotlar cikar (Equals, GetHashCode, GetType, ToString).
                  Ogrenci nesnesinin bu metotlari miras aldigi tipimizin adi objecttir.

                - Ogrenci nesnesi orneklenirken .NetFramework'un ana mantigindan yararlanir;
                  Object nesnesini alir ve ondan bir kopya alarak kendini turetir.
                  Yazilan tum fieldlar, metotlar vb. bir sablon olarak alinan object nesnesi uzerinden
                  gecerek ozel tip haline getirilir. Olusturulan bu ozel tip ise tekrar turetilinebilir ve
                  farkli tiplerde kullanilabilir.

                - Kalitim konusu, iliskisel veritabani mantiginda ortak degerlere sahip olan alanlarimizi
                  nesnesel olarak modellerken kullaniriz. Kendini tekrar eden fieldlar, metotlar vb.
                  islemleri kullanabilmek ve bir merkezilik saglamak icin 
                  (Polymorphism konusunda modellemek icin) kalitim kullanilir.

                - Classlari, database icerisindeki dataya erisip o datayi alip C#'da kullanabilmek icin
                  modelleriz. Modelledigimiz classlari ise uygulama icerisinde kullaniriz.

                - Classlar kullanilmadan da guzel uygulamalar yapilabilir ama cok uzun surer.
                  Cunku cogu sey defalarca yazilmak zorundadir. 
            
                - Nesne yonelimli programlamanin temel amaci bir veriyi, bir ana noktayi merkezilestirip
                  referanslar uzerinden giderek islemler yapmaktir.
                  
                - Bu sebepler yüzden kalitim nesne yonelimli programlamanin bir ihtiyacidir. 
                
                - C# programlama dilinde olusturulan tüm nesneler default olarak turetilmeye acik olarak gelir.
                  Eger mudahale edilmek istenirse olusturulan nesnelerin turetilmesi engellenebilir.

            */

            Egitmen E1 = new Egitmen();
            Console.WriteLine("Egitmen nesnesi orneklendi");
            E1.TemelTipMetot1();

            Personel P1 = new Personel();
            P1.TemelTipMetot1();

            Ogrenci O1 = new Ogrenci();
            O1.TemelTipMetot1();

            // Ozel Tiplerde Boxing ve Unboxing

            // Object nesnemiz burada Temel Tip'tir

            TemelTip T2;

            // Personel, Egitmen, Ogrenci nesnelerinde Temel Tip, object gorevini ustlenir
            // Temel Tip nesnesinden turetikleri icin temel tip nesnesi bu nesnelerde object gibi davranir
            
            T2 = P1; // Personel nesnesi Temel Tip nesnesine atandi, Boxing
            T2 = E1; // Egitmen nesnesi Temel Tip nesnesine atandi, Boxing
            

            E1 = (Egitmen)T2; // Objeden nesneye donus yapildi, Unboxing

            Console.ReadLine();

            object Obj1 = O1;
            O1 = (Ogrenci)Obj1;

            // Turemis olan tiplerin tekrar turememesi icin sealed keywordu kullanilir

            Muhurleme M1 = new Muhurleme();

            /* Muhurleme:Personel classindan turemesini engellemek icin 
               Personel classina sealed keywordu eklenir, nesnenin nesne ornegi alinamaz
            */

            /* Personel classi ile Egitmen classinin bazi ortak fieldlari var.
               Bu ortak fieldlari tek bir yerde yazmak yeterli ama iki class da TemelTip classindan
               kalitilmis halde. Bu yuzden yapilacak islem kalitilan nesne icerisinde kalitim yapmaktir.
               Bunun icin Egitmen nesnesini TemelTipten kalitmak yerine Personel nesnesinden kalitmak
               gereklidir. Bu sekilde Egitmen>Personel>TemelTip>Object dallanmasi olusur.
            */

            /* Kalitim konusunun kendine ozel "protected" isimli bir eriyisim belirleyicisi vardir. 
              
               public:    Uygulamanin icerisinde veya disarisinda erisilebilir. 
               private:   Sadece tanimlanan class icerisinde erisilebilir.
               protected: Normal kullanimlarda private, kalıtım yapilirken kalitilmis classlarda public erisim.
            */
          
        }
    }
}
