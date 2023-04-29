using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S17.D2.GenericCollectionsDictionarySortedListKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                -   Dictionary ve SortedList, normal koleksiyonlarda HastTable ile ayni gorevi gorur.        
                
                -   Dictionary<TKey,Tvalue> seklinde tanimlanir.

                -   SortedList<TKey,Tvalue> seklinde tanimlanir.

                -   SortedList keyleri, keylerin degerlerine gore siralar.
            */


            Dictionary<int, string> DictionaryList = new Dictionary<int, string>();

            DictionaryList.Add(1, "Bir");
            DictionaryList.Add(2, "Iki");
            DictionaryList.Add(3, "Uc");

            string GelenDeger = DictionaryList[1];

            bool SilmeSonuc = DictionaryList.Remove(4);

            bool ArananKeyDegerSonuc   = DictionaryList.ContainsKey(3);
            bool ArananValueDegerSonuc = DictionaryList.ContainsValue("Uc");

            foreach (KeyValuePair<int,string> item in DictionaryList)
            {
                Console.WriteLine(item.Key + " " + item.Value);

            }

            DictionaryList.Clear();


            SortedList<int, string> SortedListKoleksiyon = new SortedList<int, string>();

            SortedListKoleksiyon.Add(100, "100");
            SortedListKoleksiyon.Add(50, "50");
            SortedListKoleksiyon.Add(1, "Bir");
            

            Console.ReadLine();
        }
    }
}
