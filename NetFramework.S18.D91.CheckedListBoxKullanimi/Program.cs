using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D91.CheckedListBoxKullanimi
{
    static class Program
    {
        /*
           -   Onceki projelerin aynisi.
        
           -   Event olarak SelectedIndexChanged yerine ItemCheck kullanilir.
         
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
