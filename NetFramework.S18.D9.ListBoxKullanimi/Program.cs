using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D9.ListBoxKullanimi
{
    static class Program
    {
        /*
            -   Önceki programın formu kopyalanır.

            -   ComboBox yerine ListBox eklenir.

            -   .DataSource nesnesinin ToString() metotu ile calistigini biliyoruz. Override edilmedigi surece
                ilgili classin namespace'ini gosterecegini biliyoruz. Override etmeden datayi gostermek icin
                .DisplayMember = "Property Ismi" kullanılabilir.

            -   .ValueMember nesnesi ile datanin istenilen deger arka tarafta tutulabilir. Cok kullanisli degildir.
                .DisplayMember tercih edilir.

            -   Birden fazla deger seciliyorsa ve kullanılıyorsa secilen itemlerin adeti bir int degiskenine alinir.
        
            -   Item sayisi 1'e esit ise farkli bir algoritma, 1'den buyuk ise farklı bir algoritma uygulanır.

            -   Item sayisi 1'den buyuk ise secilen itemler bir listede tutulur.

            -   Olusturulan 2. formdaki buton nesnesinin ozellikleri InitializeCompenent'den silinir. 
                Class icerisinde yazilir.

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
