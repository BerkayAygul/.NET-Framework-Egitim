using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S17.D3.GenericClassKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                -   Generic class acmak icin classin ismine <T> eklenir.      

                -   Generic class olusturulurken alınan <T> tipi fieldlarda kullanilir.
                    Generic class orneklenirken ise <T> tipi kisi tarafindan belirlenir.
                    Birden fazla tip girilebilir (<T,K>) ama kesinlikle tercih edilmez.

                -   Database > MSSQL > Uygulamanin calismasi icin gerekli olan datalar > Musteri, Urun... 
                    Uygulama > C# > Datanin musteri tarafindan yonetimi > Musterinin Deger Girisleri

                -   Ornegin TBLMusteri adinda bir tablo ve bu tablonun icerisinde bazi Fieldlar var.
                    TBLMusteri:
                    ID(int) 
                    MusteriNumarasi(uniqueidentify[guid])
                    Isim nvarchar(50) (string)
                    SoyIsim nvarchar(50) (string)
                    DogumTarihi datetime (DateTime)

                    Bu Fieldlari tek tek <T,K,L> gibi ayirmak ve aktarmak mantıksızdır.

                -   Tasarim deseni olarak UnitOfWorks kullaniliyorsa Generic Class ve Generic Interface
                    kullanilir.
                    Entity Framework, Database First, Code First... yaklasimlarindan bir tanesi kullanilir.

                -   Is katmanlarini (Repository) daha dinamik yazmak, bir kez yazilan Repository'nin 
                    birden fazla kullanimi icin Generic Classlar kullanilir.

                -   Generic Repository, Entity Framework yaklasimlarinda yogun olarak kullanilir.

                -   Generic Classlar, bir classa birden fazla Entity icin isler yapma imkanı sunar.
                    
                -   Generic Class Kuralları:     
                    1- Birden fazla Generic tip alinabilir ama gercek hayatta kullanimi tercih edilmez.

                    2- where kurali ile T tipi belirlenebilir. T:Class denildigi zaman T tipi bir class
                       olmak zorundadir.
                    
                   
            */


            Musteri M1 = new Musteri();

            M1.ID = 1;
            M1.TCKimlikNo = "11111111111";
            M1.Isim = "Test";
            M1.SoyIsim = "Demo";
            M1.DogumTarihi = DateTime.Parse("01.01.1001");

            MusteriGeneric<int> MusteriGeneric1 = new MusteriGeneric<int>();

            MusteriGeneric1.ID = 1;
            MusteriGeneric1.MusteriNumarasiAl();

            MusteriGeneric<Guid> MusteriGeneric2 = new MusteriGeneric<Guid>();

            MusteriGeneric2.MusteriNumarasiAl();


            GenericRepository<Musteri> RepositoryMusteri = new GenericRepository<Musteri>();

            List<Musteri> Musteriler = RepositoryMusteri.Getir();

            RepositoryMusteri.YeniKayitEkle(null);


            GenericRepository<Urun> RepositoryUrun = new GenericRepository<Urun>();

            RepositoryUrun.Getir();

            RepositoryUrun.YeniKayitEkle(null);
        }
    }
}
