using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D3.KapsullemeOrnek2
{
    public class Musteri
    {
        private string tckimlikno; // Field



        public string TCKimlikNo // Property, value değeri program.cs de atanir
        {
            set // Propertye atanan değeri fielda at
            {
              
                if (value.Length == 11) // TC kimlik uzunluğu 11 mi?
                {
                    bool bayrak = false; // Daha sonra kullanılacak

                    for (int i = 0; i < value.Length; i++) // Girilen Değerlerin Hepsi Numara mı?
                    {
                        bool karakterKontrol = char.IsNumber(value[i]); // Her karakteri kontrol et

                        if (karakterKontrol) // Evet, girilenlerin hepsi numara
                        {
                            //  Döngüden Kendi Çıkar, İşleme Gerek Yok
                        }
                        else // Hayır, girilenlerin hepsi numara değil
                        {
                            bayrak = true;
                            break; // For döngüsü içinden çık ve bayrak kontrolü ile işlem yap
                        }
                    }
                    if (bayrak) // Girilenlerin hepsi numara değil, kullanıcıyı uyar
                    {
                         Console.WriteLine("TC Kimlik Numarası İçerisindekiler Sayısal Değer Olmalıdır");
                    }
                    else //  Girilenlerin hepsi numara, Propertye program.cs de girilmiş değeri fielda ata
                    {
                         this.tckimlikno = value;
                    }

                }
                else // Hayır, TC kimlik uzunluğu 11 değil
                {
                    Console.WriteLine("Tc Kimlik Numarası 11 Haneli Olmalidir");
                }
             

            }

            get // Değeri al ve fieldi return et, değeri okut
            {
                return tckimlikno.Substring(0, 3); //0. Indexten başla, 3 karakter göster
            }
        }



    }
}
