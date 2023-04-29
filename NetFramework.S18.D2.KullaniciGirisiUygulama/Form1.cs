using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D2.KullaniciGirisiUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = txtKullanici.Text;
            string Sifre = txtSifre.Text;

            Kullanici BulunanKullanici =  SanalDatabase.KullaniciTablo.Find(i => 
                                         i.KullaniciAdi == KullaniciAdi && i.Sifre == Sifre);

            if(BulunanKullanici != null)
            {
                Form2 F2 = new Form2(BulunanKullanici);

                F2.Show();
            }
            else
            {
                MessageBox.Show("Hatali Kullanici Bilgileri", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKullanici_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;

            T1.BackColor = Color.Yellow;
        }

        private void txtKullanici_Leave(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;

            T1.BackColor = Color.White;
        }
    }
}
