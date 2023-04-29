using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D7.DinamikFormElemanlari
{
    static class Program
    {
        /*
            -   FlowLayoutPanel nesnesi kendi icerisine eklenen elemanlari x ve y koordinatlari vermeden
                yanyana dizmek icin kullanilir.

            -   Yapilan ornekte Uret Buton'una basildiginda verilen adet kadar FlowLayoutPanel icerisine
                buton eklenir.

            -   for (int i = 1; i<=50; i++)
                {
                    Button btnTemp = new Button();

                    btnTemp.Name = "btnUretilenButon" + i.ToString();
                    btnTemp.Text = i.ToString();
                    btnTemp.Size = new System.Drawing.Size(35, 35);
                    btnTemp.UseVisualStyleBackColor = true;

                    if(Mayin1 == i || Mayin2 == i || Mayin3 == i)
                    {
                        btnTemp.Tag = true;
                    }
                    else
                    {
                        btnTemp.Tag = false;
                    }

                    btnTemp.Click += btnTemp_Click;

                    flowLayoutPanel1.Controls.Add(btnTemp);
            }
        }
          
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
