using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D8.ComboBoxKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbBoxUrunListesi.MouseWheel += new MouseEventHandler(MouseTekerlegiIptal);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ComboBoxDoldurV1();
            ComboBoxDoldurV2();
        }

        void ComboBoxDoldurV1()
        {
            foreach (var item in Database.UrunTablo)
            {
                cmbBoxUrunListesi.Items.Add(item);                
            };
        }

        void ComboBoxDoldurV2()
        {

            cmbBoxUrunListesi.DataSource = Database.UrunTablo;
        }

        private void cmbBoxUrunListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Urun U1 = cmbBoxUrunListesi.SelectedItem == null ? null : cmbBoxUrunListesi.SelectedItem as Urun;

            //ComboBox SecilenComboBox = sender as ComboBox;

            Object O1 = cmbBoxUrunListesi.SelectedItem;
            Urun U1 = (Urun)O1;

            pctBoxUrunResmi.Image = Image.FromFile(U1.UrunResmi);
            pctBoxUrunResmi.SizeMode = PictureBoxSizeMode.StretchImage;

            txtBoxUrunAdi.Text = U1.UrunAdi;
            txtBoxUrunKategorisi.Text = U1.UrunKategorisi;
            txtBoxStokAdedi.Text = U1.UrunStokAdedi.ToString();
            txtBoxYazar.Text = U1.Yazar;
            rchTxtBoxUrunBilgisi.Text = U1.UrunAciklamasi;
        }

        private void MouseTekerlegiIptal(object sender, EventArgs e)
        {
            HandledMouseEventArgs E1 = (HandledMouseEventArgs)e;
            E1.Handled = true;
        }
    }
}
