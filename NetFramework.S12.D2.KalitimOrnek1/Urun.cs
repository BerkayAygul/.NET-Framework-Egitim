using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D2.KalitimOrnek1
{
    public class Urun:BaseClass
    {
        public string Marka { get; set; } // Belirtilen markalar icerisinde urun eklenebilsin
        public string Model { get; set; }

        private decimal AlisFiyatiField;
        private decimal SatisFiyatiField;
        private decimal KampanyaFiyatiField;
        public decimal AlisFiyatiProperty
        {
            get
            {
                return this.AlisFiyatiField;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Urunun alis fiyati 0'dan kucuk veya esit olamaz");
                }
                else
                {
                    AlisFiyatiField = value;
                }
            }      
        } // 0'dan kucuk olamaz
        public decimal SatisFiyatiProperty 
        {
            get
            {
                return this.SatisFiyatiField;
            }
            set
            {
                if(value <= AlisFiyatiField)
                {
                    Console.WriteLine("Satis fiyati alis fiyatindan kucuk veya esit olamaz");
                }
                else
                {
                    SatisFiyatiField = value;
                }
            }
        
        
        
        } // Alis fiyatindan kucuk olamaz
        public decimal KampanyaFiyatiProperty 
        {
            get
            {
                return this.KampanyaFiyatiField;  
            }

            set
            {
                if(value<=0)
                {
                    Console.WriteLine("Kampanya fiyati 0'dan kucuk veya esit olamaz");
                }
                else
                {
                    KampanyaFiyatiField = value;
                }
            }

        }  // 0'dan kucuk olamaz




    }
}
