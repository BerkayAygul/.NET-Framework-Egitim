using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D9.ListBoxKullanimi
{
    public partial class BirdenFazlaUrunSecim : Form
    {
        Urun[] UrunListesi;
        public BirdenFazlaUrunSecim(Urun[] SecilenUrunler)
        {
            InitializeComponent();
            UrunListesi = SecilenUrunler;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BirdenFazlaUrunSecim_Load(object sender, EventArgs e)
        {
            foreach (var item in UrunListesi)
            {
                Button btnUrunler = new Button();
                btnUrunler.Text = item.UrunAdi;
                btnUrunler.Name = "btn" + item.ID.ToString();
                btnUrunler.Size = new System.Drawing.Size(90, 50);
                btnUrunler.Tag = item;
                btnUrunler.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btnUrunler);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            /*  Sender bir button, baska bir buttona atandi. 
                Button'un tag degerinde duran sey bir urun nesnesi, baska bir nesneye atandi.
                Arkada acik olan form bulundu, baska bir nesneye atandi.
                Group box bulundu, baska bir nesneye atandi.
                Group box sayesinde diger elemanlara ulasildi.
                
               
            */ 

            Button btn = sender as Button;
            Urun U1 = btn.Tag as Urun;

            Form F1 = Application.OpenForms["Form1"];

            GroupBox F1GBOX = (GroupBox)F1.Controls["grpboxUrunDetay"];

            ((PictureBox)F1GBOX.Controls["pctBoxUrunResmi"]).Image = Image.FromFile(U1.UrunResmi);
            ((TextBox)F1GBOX.Controls["txtBoxUrunAdi"]).Text = U1.UrunAdi;
            ((TextBox)F1GBOX.Controls["txtBoxUrunKategorisi"]).Text = U1.UrunKategorisi;
            ((TextBox)F1GBOX.Controls["txtBoxStokAdedi"]).Text = U1.UrunStokAdedi.ToString();
            ((TextBox)F1GBOX.Controls["txtBoxYazar"]).Text = U1.Yazar;
            ((RichTextBox)F1GBOX.Controls["rchTxtBoxUrunBilgisi"]).Text = U1.UrunAciklamasi;
        }
    }
}
