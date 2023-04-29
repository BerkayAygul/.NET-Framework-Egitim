using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S8.D3.SınıfOrnek1
{
    class Arac
    {
        public string Marka;
        public string Model;
        public int ModelYil;
        public decimal Km;

        public decimal AlisFiyat;
        public decimal SatisFiyat;
        public decimal MaxIndirimTutar;
        public decimal Fiyat;

        public Arac(string _marka, string _model, int _modelyil, decimal _km)
        {
            Marka = _marka;
            Model = _model;
            ModelYil = _modelyil;
            Km = _km;
        }

        public void BilgileriGoruntule()
        {
            Console.WriteLine("Marka = {0}, Model = {1}, Model Yılı = {2}, Km = {3}", Marka, Model, ModelYil, Km);
        }

        public void FiyatAta(decimal _fiyat)
        {
            decimal FiyatHesap = SatisFiyat - MaxIndirimTutar;
            if (_fiyat < FiyatHesap)
            {
                Console.WriteLine("Gecersiz Fiyat Girisi");
            }
            else
            {
                Fiyat = _fiyat;
                Console.WriteLine("Fiyat Güncellendi");
            }
        }

    }
}
