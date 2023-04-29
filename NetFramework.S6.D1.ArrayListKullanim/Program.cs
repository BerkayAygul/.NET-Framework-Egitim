using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Threading;

namespace NetFramework.S6.D1.ArrayListKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList Oluştur, Değer Ekle, Birbirlerine Ekle, Capacity ve Count bak 

            ArrayList A1 = new ArrayList();
            ArrayList A2 = new ArrayList();

            int Capacity = 0;
            int Count = 0;

            A1.Add("String 1");
            A1.Add(25);

            Capacity = A1.Capacity;
            Count = A1.Count;


            A2.Add("String 2");
            A2.Add(50);
            A2.Add(75);
            A2.Add(100);
            A2.Add("String 3");
            A2.Add("String 4");

            A1.AddRange(A2);

            Capacity = A1.Capacity;
            Count = A1.Count;
            
            #endregion

            #region Koleksiyon İçerisindeki Değere Ulaşmak

            object o1 = A1[3];
            string s1 = A1[0].ToString();
            int i1 = (int)A1[5];

            A1[2] = "Degistir";
            #endregion


            #region ArrayList Ters, Sıralama

            // Dizinin elemanlarını ters çevirme

            A1.Reverse();

            /* String ve intleri birlikte sıralayamaz
            A1.Remove("String 1");
            A1.Remove("Degistir");
            A1.Sort();
            */
            #endregion


            #region Yardımcı Komutlar

            bool kontrol1 = A1.Contains(100); // Değer var mi yok mu

            if(kontrol1 == true)
            {
                int indexDegeri1 = A1.IndexOf(100); //Indexini bulma
                A1.RemoveAt(indexDegeri1);
            }

            A2.Clear();      // Her değeri silme ve capacity azaltma
            A2.TrimToSize();

            object[] o2 = A1.ToArray(); // Arraye dönüştürme
            
            #endregion

            #region Koleksiyon İçerisindeki Değeri Silmek

            A1.RemoveAt(3);
            A1.Remove("Degistir");
            A1.RemoveRange(0, 3);
            #endregion



            Console.ReadLine();

        }
    }
}
