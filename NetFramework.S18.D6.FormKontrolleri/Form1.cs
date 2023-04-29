using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D6.FormKontrolleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            /*foreach (Control item in this.Controls)
            {
                MessageBox.Show(item.Name);
            } */
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            DialogResult Cevap1 = MessageBox.Show("Degerleri Silmek Istiyor Musunuz?", "Temizleme Islemi", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Cevap1 == DialogResult.Yes)
            {
                FormuTemizle();
            }
            else if (Cevap1 == DialogResult.No)
            {

            }

        }


        private void FormuTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    TextBox T1 = (TextBox)item;
                    T1.Text = string.Empty;
                }
            }
        }


        private void FormElemanIndexTemizle()
        {
            ((TextBox)this.Controls["txtIsim"]).Text = string.Empty;
            ((TextBox)this.Controls["txtSoyIsim"]).Text = string.Empty;
            ((TextBox)this.Controls["txtEmailAdres"]).Text = string.Empty;
            ((TextBox)this.Controls["txtTelefonNo"]).Text = string.Empty;
        }

        private void btnOnizleme_Click(object sender, EventArgs e)
        {
            frmOnizlemeKayit O1 = new frmOnizlemeKayit();

            ((TextBox)O1.Controls["txtIsim"]).Text = txtIsim.Text;
            ((TextBox)O1.Controls["txtSoyIsim"]).Text = txtSoyIsim.Text;
            ((TextBox)O1.Controls["txtEmailAdres"]).Text = txtEmailAdres.Text;
            ((TextBox)O1.Controls["txtTelefonNo"]).Text = txtTelefonNo.Text;

            O1.ShowDialog();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKullaniciEkle(new Kullanici()
            {
                Isim = txtIsim.Text,
                SoyIsim = txtSoyIsim.Text,
                EmailAdres = txtEmailAdres.Text,
                TelefonNo = txtTelefonNo.Text
            });

            Form YakalananForm = Application.OpenForms["Form1"];
            
            foreach (Form item in Application.OpenForms)
            {
                if(item.Name == "Form1")
                {
                    foreach (Control FormItem in item.Controls)
                    {
                        if(FormItem is TextBox)
                        {
                            ((TextBox)FormItem).Text = string.Empty;
                        }
                    }
                }
            }


            MessageBox.Show("Kullanici Ekleme Basarili.", "Bilgilendirme",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);  
        }


        private int YeniKullaniciEkle(Kullanici Data)
        {
            SanalDatabase.Kullanicilar.Add(Data);
            return 1;
        }
    }
}
