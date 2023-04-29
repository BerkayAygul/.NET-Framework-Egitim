using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.S17.D1.GenericCollectionsKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                -   Generic; collections, class, metot... icin yeni bir davranis bicimidir
            
                -   Guncel programlarda cok kullanilir

                -   Generic List aslinda ArrayList'in generic versiyonudur. 

                -   Array List'e deger obje olarak eklenir, sadece belli bir deger eklenmek istenirse
                    metotlarla ArrayList beslenir. List Generic kullaniminda ise listenin tanimi yapilirken
                    liste tip guvenli yapilabilir.

                -   Array List nasil olusturuluyorsa Generic List de ayni sekilde olusturulur.

                -   Generic Collections konusunda bilinmesi gereken temel kavram, <> kullanimidir.

                -   <T> : .net Framework icerisinde olan veya kisinin olusturdugu herhangi bir tip demektir.

                -   Sistem icerisinde yer almayan tipleri kisinin kendisi koyar. Ornegin Musteri classi
                    olusturup Generic List olusturulabilir.

                -   .AddRange ile birden fazla ifade koleksiyonun icerisine eklenilebilir. 
                
                -   Count sayisi 1, Capacity 4 olarak artar.

                -   Capacity degerinin Count degeri ile esit olmasi icin .TrimExcess() metotu kullanilir.
               
                -   ForEach dongusunu daha cabuk yazmak icin delegeler yardimiyla
                    .ForEach(i => Console.WriteLine(i)) seklinde yapilabilir
                    => Ilgili koleksiyon icerisinde arama yap

                -   Koleskiyonda bir Index'in degerine deger atamak icin .Insert(Index,Item)
                    Index'in degeri degisir ama eski index kaybolmaz. 
                    Eski Index'in numarasi bir artar ve degeri degismez.

                -   Koleksiyonun icerisinde data olup olmadigina .Any(Delege) metotu ile bakilir.
                    Data var ise True, yok ise False degerini geri gonderir.
                    Delegeler ile kosul degistirilebilir.
                    Ornegin: .Any(i => i > 5) 
                    Her degeri i olarak varsay, bunlarin icerisinde bir arastirma yap. i'nin herhangi bir 
                    degeri 5'den buyuk ise true dondur, 5'den kucuk ise false dondur.

                -   Koleksiyon icerisinde siralama yapmak icin .Sort ve .Reverse metotlari kullanilir.
                    .Sort kucukten buyuge;    A-Z, 1-N seklinde siralama yapar.
                    .Reverse buyukten kucuge; Z-A, N-1 seklinde siralama yapar.
                
                -   Koleksiyondan eleman silmek icin .Remove(Item), .RemoveAll(Delege). RemoveAt(Index)
                    metotlari kullanilir.
                    .Remove(Item): Item'i koleksiyonun icerisinde arar, bulur ve siler. 
                    .RemoveAll(i => i > 3): 3'den buyuk degeri olan Itemlari bul ve sil.
                    .RemoveAt(Index): Girilen Index numarasini koleksiyon icerisinde bul ve sil.

                -   Koleksiyonun icerisindeki en yuksek degeri almak icin .Max() metotu kullanilir.
                    Koleksiyonun icerisindeki en dusuk  degeri almak icin .Min() metotu kullanilir.

                -   Koleksiyonun icerisindeki degerlerin toplamini almak icin .Sum() metotu kullanilir.

                -   Koleksiyonun icerisindeki her seyi silmek icin .Clear() metotu kullanilir.

                
            */

            //
            ArrayList List = new ArrayList();
            List.Add("Obje1");
            List.Add(1);


            //
            List<int> Sayilar = new List<int>();
            Sayilar.Add(10);
            Sayilar.Add(20);

            for(int i=0; i<Sayilar.Count; i++)
            {
                Console.WriteLine(Sayilar[i]);
            }


            //
            List<string> Isimler = new List<string>();
            Isimler.Add("String1");


            //
            List<Musteri> MusteriListe = new List<Musteri>();
            MusteriListe.Add(new Musteri() // Hızlı nesne tanimi
            {
                ID = 1,
                Isim = "William",
                SoyIsim = "Marshall"

            });


            foreach (Musteri item in MusteriListe)
            {
                Console.WriteLine(item.Isim);
                Console.WriteLine(item.SoyIsim);
            }

            // 
            List<int> Sayilar2 = new List<int>();
            int[] EklenilecekDizi = new int[4];

            EklenilecekDizi[0] = 25;
            EklenilecekDizi[1] = 50;
            EklenilecekDizi[2] = 75;
            EklenilecekDizi[3] = 100;

            Sayilar2.AddRange(EklenilecekDizi);

            Sayilar2.ForEach(i => Console.WriteLine(i));

            Sayilar2.Insert(3, 1000);

            bool Kontrol1 = Sayilar2.Any();
            bool Kontrol2 = Sayilar2.Any(i => i > 500);

            Sayilar2.Sort();
            Sayilar2.Reverse();

            bool SilmeIslemi = Sayilar2.Remove(100);
            int SilinenAdet = Sayilar2.RemoveAll(i => i > 75);
            Sayilar2.RemoveAt(2);

            int EnYuksekDeger = Sayilar2.Max();
            int EnDusukDeger  = Sayilar2.Min();

            int DegerlerToplami = Sayilar2.Sum();

            Sayilar2.Clear();

        }
    }
}
