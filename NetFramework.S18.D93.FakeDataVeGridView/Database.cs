using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D93.FakeDataVeGridView
{
    public class Database
    {
        public List<Musteri> Musteriler = new List<Musteri>();

        public Database()
        {

        }

        public List<Musteri> MusterileriListele()
        {
            for (int i = 1; i < 1000; i++)
            {
                Musteri Temp = new Musteri();
                Temp.ID = 1000 + i;
                Temp.Isim = FakeData.NameData.GetFirstName();
                Temp.Soyisim = FakeData.NameData.GetSurname();
                Temp.TamIsim = $"{Temp.Isim} {Temp.Soyisim}";
                Temp.EmailAdres = FakeData.NetworkData.GetEmail(Temp.Isim, Temp.Soyisim);
                Temp.TelefonNo = FakeData.PhoneNumberData.GetPhoneNumber();
                Temp.Il = FakeData.PlaceData.GetCity();
                Temp.Ilce = FakeData.PlaceData.GetCounty();
                Temp.Adres = FakeData.PlaceData.GetAddress();

                Musteriler.Add(Temp);
            }
            return Musteriler;
        }
    }
}
