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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstBoxUrunListesi.MouseWheel += new MouseEventHandler(MouseTekerlegiIptal);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ListBoxDoldur();
        }


        /*void ListBoxDoldurV1()
        {
            foreach (var item in Database.UrunTablo)
            {
                lstBoxUrunListesi.Items.Add(item);
            };
        }*/

        void ListBoxDoldur()
        {
            lstBoxUrunListesi.DisplayMember = "UrunAdi";
            //lstBoxUrunListesi.ValueMember = "ID";
            lstBoxUrunListesi.DataSource = Database.UrunTablo;
        }

        private void lstBoxUrunListesi_SelectedIndexChanged(object sender, EventArgs e)
        {

            int UrunSecimAdeti = lstBoxUrunListesi.SelectedItems.Count;

            if (UrunSecimAdeti == 1)
            {
                // ListBox lbox = (ListBox)sender;
                Object O1 = lstBoxUrunListesi.SelectedItem;
                Urun U1 = (Urun)O1;

                pctBoxUrunResmi.Image = Image.FromFile(U1.UrunResmi);
                pctBoxUrunResmi.SizeMode = PictureBoxSizeMode.StretchImage;

                txtBoxUrunAdi.Text = U1.UrunAdi;
                txtBoxUrunKategorisi.Text = U1.UrunKategorisi;
                txtBoxStokAdedi.Text = U1.UrunStokAdedi.ToString();
                txtBoxYazar.Text = U1.Yazar;
                rchTxtBoxUrunBilgisi.Text = U1.UrunAciklamasi;
            }
            else if(UrunSecimAdeti > 1)
            {
                List<Urun> SecilenUrunListe = new List<Urun>();
                foreach (var item in lstBoxUrunListesi.SelectedItems)
                {
                    SecilenUrunListe.Add(item as Urun);
                }

                BirdenFazlaUrunSecim CokluUrunSecim = new BirdenFazlaUrunSecim(SecilenUrunListe.ToArray());
                CokluUrunSecim.ShowDialog();
            }
            else
            {
                MessageBox.Show("Detayini gormek istediginiz urunu seciniz", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void MouseTekerlegiIptal(object sender, EventArgs e)
        {
            HandledMouseEventArgs E1 = (HandledMouseEventArgs)e;
            E1.Handled = true;
        }

    }
}
