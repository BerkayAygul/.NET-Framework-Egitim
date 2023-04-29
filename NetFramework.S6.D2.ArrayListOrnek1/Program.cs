using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace NetFramework.S6.D2.ArrayListOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciSecimi = string.Empty;
            ArrayList degerListesi = new ArrayList();

            do
            {
                Console.Clear();

                Console.WriteLine("Menü");
                Console.WriteLine("1- Değer Ekle");
                Console.WriteLine("2- Değer Listele");
                Console.WriteLine("3- Değer Ara");
                Console.WriteLine("4- Değer Düzenle");
                Console.WriteLine("5- Değer Sil");
                Console.WriteLine("6- Uygulama Çıkış");
                Console.Write("\nSeçiniz: ");

                kullaniciSecimi = Console.ReadLine();
                

                


                switch (kullaniciSecimi)
                {
                    case "1":
                        TekrarGir: 

                        Console.Write("\nEklemek istediğiniz bir değeri giriniz: ");
                        string kullaniciDeger = Console.ReadLine();
                        degerListesi.Add(kullaniciDeger);
                        Console.WriteLine("\nDeğeriniz eklendi.\n");

                    TekrarGir2:

                        Console.WriteLine("Başka değer eklemek istiyorsanız 0 tuşuna basınız.");
                        Console.Write("Menüye dönmek için 9 tuşuna basınız: ");

                        string tekrar = Console.ReadLine();

                        if(tekrar == "0")
                        {
                            goto TekrarGir;
                        }

                        else if (tekrar == "9")
                        {
                            System.Threading.Thread.Sleep(2000);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nYanlış tuşa bastınız.");
                            goto TekrarGir2;
                        }
                        
                        
                    case "2":
                        Console.WriteLine("\nGirdiginiz degerlerin Listeleri:");
                        for (int i = 0; i < degerListesi.Count; i++)
                        {
                            Console.WriteLine("{0}. Değer = {1}", i, degerListesi[i]);
                        }
                        Console.Write("\n\nMenüye dönmek için herhangi bir tuşa basınız: ");
                        Console.ReadLine();
                        System.Threading.Thread.Sleep(2000);
                        break;


                    case "3":  

                        Console.Write("\n\nAramak istediğiniz değeri giriniz: ");
                        string kullaniciAramaDegeri = Console.ReadLine();
                        bool kontrol1 = degerListesi.Contains(kullaniciAramaDegeri);

                        if (kontrol1)
                        {
                            int bulunanIndex = degerListesi.IndexOf(kullaniciAramaDegeri);
                            string arananDeger = degerListesi[bulunanIndex].ToString();
                            Console.WriteLine("\nDeğer Bulundu. Index numarası = {0} - değer = {1}", bulunanIndex, arananDeger);
                            Console.Write("\n\nMenüye dönmek için bir tuşa basınız: ");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Değer Bulunamadı. Bu değer listeye eklensin mi?");
                            TekrarGir3:
                            Console.WriteLine("E/H");
                            string ekleme = Console.ReadLine();
                            ekleme.ToLower();

                            if(ekleme == "e")
                            {
                                degerListesi.Add(kullaniciAramaDegeri);
                                Console.WriteLine("\n\nDeğeriniz Eklendi.");
                                Console.WriteLine("Menüye dönmek için bir tuşa basınız.");
                                Console.ReadLine();
                                break;
                            }

                            else if (ekleme == "h")
                            {
                                Console.WriteLine("Menüye dönülüyor.");
                                System.Threading.Thread.Sleep(2000);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Yanlış tuşa bastınız.");
                                goto TekrarGir3;
                            }
                        }
                        break;

                    case "4":
                        Console.Write("Düzenlemek istediğiniz değeri giriniz: ");
                        string degerDuzenle = Console.ReadLine();


                        if (degerListesi.Contains(degerDuzenle))
                        {
                            Console.WriteLine("\n{0} Değerini hangi değer ile güncellemek istiyorsunuz?\n", degerDuzenle);
                            string yeniDeger = Console.ReadLine();
                            int DuzenlenecekIndex = degerListesi.IndexOf(degerDuzenle);
                            degerListesi[DuzenlenecekIndex] = yeniDeger;
                            Console.WriteLine("Değer güncellendi. Menüye dönmek için bir tuşa basınız.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("\nDeğer bulunamadı. Menüye dönmek için bir tuşa basınız.");
                            Console.ReadLine();
                        }
                        break;

                    case "5":
                        
                        EvetHayir:

                        Console.WriteLine("Tüm değerleri mi silmek istiyorsunuz?");
                        Console.WriteLine("E/H");

                        string hepsiniSil = Console.ReadLine();
                        hepsiniSil.ToLower();

                        if (hepsiniSil == "e")
                        {
                            degerListesi.Clear();
                            Console.WriteLine("Tüm değerler silindi.");
                            Console.WriteLine("Menüye dönmek için bir tuşa basınız.");
                            Console.ReadLine();
                        }
                        
                        else if (hepsiniSil == "h")
                        {
                            Console.WriteLine("\nHangi degeri silmek istiyorsunuz?");
                            string degerSilme = Console.ReadLine();
                        

                            
                            if(degerListesi.Contains(degerSilme))
                            {
                            degerListesi.Remove(degerSilme);
                            Console.WriteLine("Değer silindi. Menüye dönmek için bir tuşa basınız.");
                            Console.ReadLine();
                            }
                            else
                            {
                            Console.WriteLine("\nDeğer bulunamadı. Menüye dönmek için bir tuşa basınız.");
                            Console.ReadLine();
                            }
                        }

                        else
                        {
                            Console.WriteLine("Yanlış tuşa bastiniz.");
                            goto EvetHayir;
                        }

                        break;

                    default:
                        break;
                }

            } while (kullaniciSecimi != "6");
        }
    }
}
