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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database DB = new Database();
            List<Musteri> MusteriListesi = DB.MusterileriListele();
            dgvMusteriListe.DataSource = MusteriListesi;

            // Belirli bir sutunun kullanıcıya gozukmesi engellenebilir.
            dgvMusteriListe.Columns[0].Visible = true;
            //dgvMusteriListe.Columns["ID"].Visible = false;

            // Belirli bir sutunun ismini degistirmek
            dgvMusteriListe.Columns[1].HeaderText = "Musteri Isim";
            dgvMusteriListe.Columns[2].HeaderText = "Musteri Soyisim";
            dgvMusteriListe.Columns[2].Width = 100;

            // Datalardan bazilari lazim degilse ve gozukmesi istenmiyorsa kullanılır.
            // LINQ data sorgusu, Liste icerisinde bir arama yap. Her bir datayı I nesnesi olarak al. Bu datayı bir liste olarak geri don.
            var dgvSorguListe = from I in MusteriListesi select new
            {
                ID = I.ID,
                Isim = I.Isim,
                Soyisim = I.Soyisim,
                TamAdi = I.TamIsim
            };
            dgvMusteriListe.DataSource = dgvSorguListe.ToList();
        }

        // Secili olan hucrenin satir index numarasini ver.
        private void dgvMusteriListe_DoubleClick(object sender, EventArgs e)
        {
            int MusteriID = (int)dgvMusteriListe[0, dgvMusteriListe.CurrentCell.RowIndex].Value;
            MessageBox.Show(MusteriID.ToString());
                
            // Tiklanilan ID numarasini al, database icerisinde bu ID numarasiyla arama yap. Bulabilirsen o kisiyi gonder, bulamazsan null gonder.
            Database DB = new Database();
            Musteri BulunanMusteri = DB.MusterileriListele().FindAll(i => i.ID == MusteriID).FirstOrDefault();

            PopupMesaj Popup = new PopupMesaj(BulunanMusteri);
            Popup.Show();
        }
    }
}
