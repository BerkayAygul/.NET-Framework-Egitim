/*
 
    1-  Musteri adinda bir nesne olusturulacak
    2-  Olusturulan Musteri nesnesi icerisine static bir ArrayList olusturulacak
    3-  ArrayList koleksiyonu sanal bir database mantigi ile kullanılacak
    4   Musteri sınıfının içerisine:
        a)  ID
        b)  Isim
        c)  Soyisim
        d)  Email
        e)  Kullanici Adi
        f)  Sifre
        Fieldlari olusturulacak
    5-  Olusturulan bu fieldlarin bazilarinin kapsulleme filtreleri assagidaki gibi olmalidir:
        a)  Kullanici adi sanal database icerisinde aransin, bulunursa field icerisine eklenilmesi engellensin
        b)  Musteri ekle adinda static bir metot olusturulacak, parametre olarak musteri tipi alacak
        c)  Metot, Musteri nesnesinin null olup olmadigini ve musteri nesnesi icerisindeki kullanici adinin
            dolu olmasi sartina bakacak
        d)  Yukaridaki kriterlerden gecilirse musteri sanal olarak olusturulan databaseye eklenmeden once
            email adresinden kontrol saglanacak. Eger sistemde ayni email adresi ile bir musteri degeri varsa
            deger eklenmeyecek; musteri degeri yok ise email adresi eklenilecek.
  
*/