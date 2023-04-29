using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S5.D2.DiziOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int veri tipinde bir dizi oluştur.
               Kullanıcı, dizinin kaç elemanlı olacağının bilgisini versin.
               Kullanıcı, dizinin içindeki alanlara doğal sayı ataması yapsın. 
               Program, dizi içerisindeki elemanların toplamlarını ve ortalamalarını yazdırsın
            */

            #region 

            string veriGirisi = string.Empty;

            Console.Write("Dizi Kaç Elemanlı? ");
            veriGirisi = Console.ReadLine();

            int[] veriDizisi = new int[int.Parse(veriGirisi)];


            for (int sayac = 0; sayac < veriDizisi.Length; sayac++)
            {
                Console.Write("{0}. Indexe veri gir = ", sayac);
                veriDizisi[sayac] = int.Parse(Console.ReadLine());

            }

            int dizilerinToplamlari = 0 , dizilerinOrtalamaları = 0;

            Console.WriteLine("\nDizilerin Toplamları:\n");

            foreach (int item in veriDizisi)
            {
                Console.WriteLine("\t{0}", item);
                dizilerinToplamlari = dizilerinToplamlari + item;
            }
           
            Console.WriteLine("+_____________");
            Console.WriteLine("\t{0}", dizilerinToplamlari);

            dizilerinOrtalamaları = dizilerinToplamlari / veriDizisi.Length;

            Console.WriteLine("\n\nDizilerin Ortalamaları = {0}", dizilerinOrtalamaları);
            

            #endregion
            Console.ReadLine();

        }

     }
 }
    
