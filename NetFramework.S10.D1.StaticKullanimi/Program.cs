using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D1.StaticKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            
             // Static, nesne örneği alınmadan ulaşabildiğimiz metot, field veya bunları barındıran bir sınıf olabilir.
             
             Ogrenci O1; // Stack bölge içerisinde pointerimiz oluştu

            /* Stack bölgede pointer oluştuğu zaman static olan bir yapıcı metot çalıştı ve class içerisinde tanımlı olan
            field, metot vb. static dediğimiz bölgede oluştu */

            Ogrenci.Test2(); // Nesne stack bölgeye geçmeden static metot kullanıldı
            // O1.Test2() ile statik bolgeye erisim saglanılamaz.

            O1 = new Ogrenci(); // Stack bölgede oluşan pointer kendisini Heap bölgede static olmayan tanımlarını tamamladı
            // new ile nesne ornegi alinmadan O1 degeri null olarak kalir


            O1.Test1(); // Nesne Örneği alındıktan sonra Test1 adlı metota ulaşıldı

            /* İçinde buluduğu sınıftan nesne oluşturulmadan veya hiç bir nesneye referans olmadan 
            kullanılabilen üyeler static olarak nitelendirilir */

            /* Static olmayan metotlar, static metotları cagirabilir
               Static metotlar ise sadece static olan metotları cagirabilir */


            /* Static Kavrami neden ve nerelerde kullanilir?
              
               1- Farkli parca metotları bir arada tutmak istedigimiz yardimci metotlarda kullanilir.
                
                  Helper.cs > Kontroller (Alınan mail, isim, soyisim, tc...) projeye bağımlı olmaz.
                  Istenilen classda kullanilabilir. Daginik yapidaki kontrolleri class altinda toplamak
                  icin kullanilir.

               2- Olusturulan nesnede kontrollere ulasmak icin nesnenin ornegini almak istemeden,
                  ornegin Helper.cs olusturmadan yapmak isteyince kullanilir.
                
                  Olusturulan nesne > bagımliligi farkli classlara oldugu icin 
                  (proje icerisinde ozel oldugu icin) nesne icerisinde statik tanimlar yapilir

               3- Class icerisinde bir static field tanimi yapilir, ilgili field icerisine
                  bir deger atamasi yapilir. Daha sonra uygulama icerisinde N farkli yerde olusturulan
                  static fielde ulasilir, deger okunur. 

               4- Genel olarak bagimli kalinmayacak, Helper gibi davranmasi istenilen ama ozel olarak
                  yazilan islemlerde kullanilabilir.

                  Uygulama > ozelHelper (static metotlar ve fieldlar icerir) > DLL

            */

        }
    }
}
