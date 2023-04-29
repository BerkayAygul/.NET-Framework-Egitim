using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;

namespace NetFramework.S6.D4.HashTableOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             Hash Table içerisine ENG - TR Kayıt Ekle
             E : Yeni Kayıt Ekleme İşlemini Devam Ettir
             H : Tüm Listeyi Yazdir
             Var olan kayıt eklenmeye çalışıyorsa kullanıcıyı uyar
          */

            Hashtable Sozluk = new Hashtable();

            do
            {
                Console.Clear();
                TekrarGir:

                Console.WriteLine("\nEklemek İstediğiniz İngilizce Kelimeyi Giriniz");
                Console.Write("ENG: ");
                string ingilizce = Console.ReadLine();
                ingilizce = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ingilizce);

                bool kontrol = Sozluk.ContainsKey(ingilizce);

                if(kontrol)
                {
                    Console.WriteLine("Eklemek İstediğiniz Kelime Zaten Sözlükte Bulunmaktadır!\n");
                    goto TekrarGir;
                }
                else
                {
                    Console.WriteLine("\nEklemek İstediğiniz Kelimenin Türkçe Karşılığı Kelimeyi Giriniz");
                    Console.Write("TR: ");
                    string turkce = Console.ReadLine();

                    Sozluk.Add(ingilizce, turkce);

                    Console.WriteLine("\nSözcük Eklemeye devam etmek istiyor musunuz?");
                    Console.Write("E/H: ");
                }

            } while (Console.ReadLine().ToLower() == "e");

            Console.Clear();

            foreach (var item in Sozluk.Keys)
            {
                Console.WriteLine("\nİngilizce= {0} - Türkçe= {1}",item , Sozluk[item]);
            }

            Console.ReadLine();
                

        }
    }
}
