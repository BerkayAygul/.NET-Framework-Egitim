using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D91.CheckedListBoxKullanimi
{
    public static class Database
    {
        public static List<Urun> UrunTablo = new List<Urun>()
        {
            new Urun()
            {
            ID = 1, UrunAdi = "Suç ve Ceza", UrunStokAdedi = 10,
            UrunKategorisi = "Klasik Roman", Yazar = "Fyodor M. Dostoyevski",
            UrunAciklamasi =
            "Dostoyevski’nin Rusya’yı, Rus halkını gözlemleyerek içlerinden çekip çıkardığı" +
            "Raskolnikov hem yazarın hem de edebiyat tarihinin en karanlık karakteridir. " +
            "Yoksulluğunun güzel ve parlak bir hayat kurmasına izin vermeyeceğine inanan genç bir hukuk öğrencisinin," +
            " yaşlı tefeci kadını öldürüp parasını çalmayı planlamasıyla başlayan hikâyesi, " +
            "Raskolnikov’un ikilemlerinden, iç çatışmalarından hareketle insanlığa sorduğu ahlaki ve " +
            "felsefi sorularla edebiyatı başka bir boyuta taşımıştır."+
            "\n\nSuç ve Ceza yayımlandığı 1866 tarihinden bu yana, modern insana yaklaşımıyla ve sorduğu " +
            "can alıcı sorularla güncelliğini hiç kaybetmediği gibi, edebiyatın çıtasını erişilmesi güç bir " +
            "seviyeye yükseltmiştir. Dostoyevski’nin dehasını tüm yönleriyle yansıttığı roman, " +
            "bir suçun psikolojik kaydıdır aynı zamanda.",
            UrunResmi = @"D:\C#\NetFramework\NetFramework.S18.D8.ComboBoxKullanimi\KitapResim\1.jpg"
            },

            new Urun()
            {
            ID = 2, UrunAdi = "Nutuk", UrunStokAdedi = 25,
            UrunKategorisi = "Tarih", Yazar = "Mustafa Kemal Atatürk",
            UrunAciklamasi =
            "Bugünü doğru anlayabilmek ve geleceği doğru kurabilmek için geçmişi, " +
            "buraya nasıl, nerelerden geçerek geldiğimizi iyi bilmek gerekir. " +
            "Nutuk, dünyada emperyalizme karşı kazanılan ilk Kurtuluş Savaşı'nı ve " +
            "Türkiye Cumhuriyeti'nin kuruluş sürecini birinci ağızdan anlatan temel eser olma özelliğini koruyor, " +
            "ülkemizin bugünü ve geleceği için de yol göstermeye devam ediyor.",
            UrunResmi = @"D:\C#\NetFramework\NetFramework.S18.D8.ComboBoxKullanimi\KitapResim\2.jpg",
            },

            new Urun()
            {
            ID = 3, UrunAdi = "İmparatorluğun En Uzun Yüzyılı", UrunStokAdedi = 20,
            UrunKategorisi = "Tarih", Yazar = "Prof. Dr. lber Ortayli",
            UrunAciklamasi =
            "19. yüzyılda Osmanlı İmparatorluğu’nun modernleşme sürecini, " +
            "siyasi, toplumsal ve kültürel değişiklikleri Prof. Dr. İlber Ortayli ele aliyor.",
            UrunResmi = @"D:\C#\NetFramework\NetFramework.S18.D8.ComboBoxKullanimi\KitapResim\3.jpg"
            },

            new Urun()
            {
            ID = 4, UrunAdi = "Yüzüklerin Efendisi - Tek Cilt Özel Basım", UrunStokAdedi = 10,
            UrunKategorisi = "Fantastik Roman", Yazar = "John R. R. Tolkien",
            UrunAciklamasi =
            "Dünya ikiye bölünmüştür, denir Tolkien’ın yapıtı söz konusu olduğunda:" +
            " Yüzüklerin Efendisi’ni okumuş olanlar ve okuyacak olanlar. " +
            "Yapıtın bu başarısını taçlandırmak için üç kısmı bir araya getiren bu özel, " +
            "tek cilt edisyonu sunuyoruz. Hem hala okumamış, okuyacak olanlar için, " +
            "hem de bu güzel kitabın kütüphanenizde gelecek kuşaklara devrolacak kadar kalıcı olması için..." +
            "\nYüzüklerin Efendisi yirminci yüzyılın en çok okunan yüz kitabı arasında en başta geliyor; " +
            "bilimkurgu, fantazi, polisiye, best-seller ya da ana akım demeden, tüm edebiyat türleri arasında " +
            "tartışmasız bir önderliğe sahip. Bir açıdan bakarsanız bir fantazi romanı, " +
            "başka bir açıdan baktığınızda, insanlık durumu, sorumluluk, iktidar ve savaş üzerine bir roman." +
            " bir yolculuk, bir büyüme öyküsü; fedakarlık ve dostluk üzerine, hırs ve ihanet üzerine bir roman.",
            UrunResmi = @"D:\C#\NetFramework\NetFramework.S18.D8.ComboBoxKullanimi\KitapResim\4.jpg"
            },

            new Urun()
            {
            ID = 5, UrunAdi = "Assassin's Creed: Gizli Sefer", UrunStokAdedi = 5,
            UrunKategorisi = "Fantastik Roman", Yazar = "Oliver Bowden",
            UrunAciklamasi =
            "Marco'nun babası Niccolò Polo, tüm hayatı boyunca sır olarak tuttuğu hikâyeyi en sonunda " +
            "anlatmaya başlayacaktı - Yoldaşlık'ın en olağanüstü Assasinlerinden Altaïr'in hikâyesini… " +
            "Son derece zor ve korkutucu bir görevle yola çıkan Altaïr, Kutsal Toprakların dört bir yanında " +
            "düşmanlarının canını alırken Assasin Amentüsü'nün, yani Suikastçının İnancı'nın da gerçek anlamını " +
            "görüp anlayacaktı. Tarikata olan bağlılığını ispat etmesi gereken Altaïr, aralarında " +
            "Tapınakçıların lideri Robert de Sable'ın da bulunduğu dokuz ölümcül düşmanını ortadan " +
            "kaldırmak zorundaydı." +
            "Altaïr'in yaşam öyküsünün ilk kez anlatıldığı bu kitapta, " +
            "tarihin gidişatını değiştirecek bir serüven sizleri bekliyor." +
            " Tapınakçı komplosuna karşı Altaïr'in giriştiği bitmek bilmeyen mücadele… " +
            "Hem şaşırtıcı hem de trajik tarafları olan aile hayatı…" +
            " Ve en sonunda eski bir arkadaşının ihaneti... " +
            "\n\nHakikat kanla yazılacak! Kanla ve Suikastçının İnancı'yla!...",
            UrunResmi = @"D:\C#\NetFramework\NetFramework.S18.D8.ComboBoxKullanimi\KitapResim\5.jpg"
            },

        };
    }
}
