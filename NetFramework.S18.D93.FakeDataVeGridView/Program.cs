using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D93.FakeDataVeGridView
{
    static class Program
    {
        /*
            -   Fake data kullanimi icin FakeData Nuget Package indirilmesi gerekir.

            -   Paket .dll uzantili olarak gelir ve icerisinde bazi static bilgiler barinir.

            -   Ornek olarak bir personel listesi ve bu listenin icerisine kisinin ismini, soyismini, e-mail adresini ve benzeri islemleri
                yazarız. Belirli bir sure sonra tekrar eden olayları aradan cıkarmak icin FakeData kullanilir.

            -   Kullanicidan data gelmis gibi database doldurulur ve ilgili datayi incelemek icin kullanilir.

            -   Database icerisinde temp denilen test datasi barindirilir.

            -   FakeData. namespace kullanilarak classlar ve static metotlar gorulebilir.

            -   FakeData.GetFirstName(); metotu ile iceride tanimlanmis olan static bir nesneden rastgele bir isim degeri getirir.

            -   Musteri nesnesi fake data ile doldurulacak.

            -   Datalari normal sartlarda ListBox veya CheckBox gibi ufak kontroller ile gosterilebilir.

            -   Bir data kumesini yogun bir sekilde, liste olarak DataGridView ile gosterilir. 

            -   Choose Data Source ile data Form elemani uzerinden alinabilir. Kodsal ile yazılması daha dogru.

            -   Dock in Parent Container secenegi ile DataGridView kendisini ilgili Container icerisinde acar (GroupBox).

            -   Form classinin icerisinde kodlarin aciklamalari var.

            -   SelectionMode > FullRowSelect

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
