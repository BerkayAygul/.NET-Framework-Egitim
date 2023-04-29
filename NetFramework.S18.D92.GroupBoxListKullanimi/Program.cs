using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D92.GroupBoxListKullanimi
{
    static class Program
    {
        /*
           -   Icerisindeki kontrollere mudahele etmeyi saglar. Foreach dongusu kullanilabilir.
        
           -   Once Form kullanilarak GroupBox'a ulasilir, daha sonra GroupBox'un icerisindeki kontrollere ulasilir.

           -    GroupBox'un kendi kontrolleri bulunur.
         
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
