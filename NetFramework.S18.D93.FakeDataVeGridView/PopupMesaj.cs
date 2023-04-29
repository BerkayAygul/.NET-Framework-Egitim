using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D93.FakeDataVeGridView
{
    public partial class PopupMesaj : Form
    {
        Musteri MusteriBilgisi;
        public PopupMesaj(Musteri Data)
        {
            InitializeComponent();
            MusteriBilgisi = Data;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopupMesaj_Load(object sender, EventArgs e)
        {
            txtIsim.Text = MusteriBilgisi.Isim;
            txtSoyIsim.Text = MusteriBilgisi.Soyisim;
            txtTamIsim.Text = MusteriBilgisi.TamIsim;
            txtTel.Text = MusteriBilgisi.TelefonNo;
            txtMail.Text = MusteriBilgisi.EmailAdres;
            TxtIlveIlce.Text = $"{MusteriBilgisi.Il}/ {MusteriBilgisi.Ilce}";
            txtAdres.Text = MusteriBilgisi.Adres;
        }
    }
}
