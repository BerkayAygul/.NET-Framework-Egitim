using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D4.MessageBoxNotificationKontrolleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            int IslemSonuc = YeniMusteriEkle(new Musteri() {
            
            ID = Guid.NewGuid(),
            Isim = txtIsim.Text,
            SoyIsim = txtSoyIsim.Text,
            EmailAdres = txtMailAdres.Text,
            TelefonNo = txtTelefon.Text
            
            });

            if(IslemSonuc > 0)
            {
                DialogResult Sonuc = MessageBox.Show("Musteri Ekleme Islemi Basarili. Yeni Musteri Kaydi Eklemek Ister Misiniz?",
                    "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(Sonuc == DialogResult.Yes)
                {
                    BildirimCubugu = new NotifyIcon();

                    BildirimCubugu.BalloonTipTitle = "Musteri Adet Bilgisi";
                    BildirimCubugu.BalloonTipText = "Toplam Musteri Kayit Sayisi: " + 
                                                     SanalDatabase.Musteriler.Count.ToString();
                    BildirimCubugu.Visible = true;
                    BildirimCubugu.Icon = SystemIcons.Information;
                    BildirimCubugu.ShowBalloonTip(2000);

                }
                else if (Sonuc == DialogResult.No)
                {

                }

                EkraniTemizle();
                EkraniListele();
                
            }
            else
            {
                MessageBox.Show("Kayit Ekleme Islemi Yapilamadi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private int YeniMusteriEkle(Musteri Data)
        {
            SanalDatabase.Musteriler.Add(Data);
            return 1;
        }

        private void EkraniTemizle()
        {
            txtIsim.Text = string.Empty;
            txtSoyIsim.Text = string.Empty;
            txtMailAdres.Text = string.Empty;
            txtTelefon.Text = string.Empty;
        }

        private void EkraniListele()
        {
            lstMusteriler.DataSource = SanalDatabase.Musteriler;
        }
    }
}
