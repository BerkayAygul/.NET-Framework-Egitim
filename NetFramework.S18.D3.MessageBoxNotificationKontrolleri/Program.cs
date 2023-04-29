using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D4.MessageBoxNotificationKontrolleri
{
    static class Program
    {
        /*
            -   Group Box nesnesi form elemanlarini gruplamak icin kullanilir. Kendi icerisinde bir controller
                yapisi vardir.

            -   ListBox'a Data'nin kendisi gonderilebilir. ToString() metotu override edilmez ise 
                namespace gozukur.

            -   NotifyIcon nesnesinin icerisindeki bilgiler tam olarak doldurulmaz ise nesne kendisini gostermez.
                

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
