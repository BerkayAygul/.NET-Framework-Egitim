using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D2.KullaniciGirisiUygulama
{
    public partial class Form2 : Form
    {
        public Form2(Kullanici BulunanKullanici)
        {
            InitializeComponent();

            txtBilgiIsim.Text = BulunanKullanici.Isim;
            txtBilgiSoyIsim.Text = BulunanKullanici.SoyIsim;
            txtBilgiKullaniciAdi.Text = BulunanKullanici.KullaniciAdi;
            txtBilgiSifre.Text = BulunanKullanici.Sifre;
            txtBilgiAciklama.Text = BulunanKullanici.Aciklama;

            txtBilgiIsim.Enabled = false;
            txtBilgiSoyIsim.Enabled = false;
            txtBilgiKullaniciAdi.Enabled = false;

            btnBilgiGuncelle.Tag = BulunanKullanici.ID;

            lblKullaniciSelamla.Text = "Merhaba " + BulunanKullanici.Isim + " " + BulunanKullanici.SoyIsim;
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            //Button GuncelleYakala = (Button)sender;

            int IDAl = (int)btnBilgiGuncelle.Tag;

            int Index = SanalDatabase.KullaniciTablo.FindIndex(i => i.ID == IDAl);

            SanalDatabase.KullaniciTablo[Index].Sifre = txtBilgiSifre.Text;
            SanalDatabase.KullaniciTablo[Index].Aciklama = txtBilgiAciklama.Text;

            MessageBox.Show("Bilgileriniz Guncellendi", "Guncelleme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
    }
}
