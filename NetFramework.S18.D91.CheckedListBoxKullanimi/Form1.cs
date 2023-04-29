using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D91.CheckedListBoxKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckedListBoxDoldur();
        }

        private void CheckedListBoxDoldur()
        {
            foreach (var item in Database.UrunTablo)
            {
                chkListBox.Items.Add(item);
            }
        }

        private void chkBoxList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedListBox = (CheckedListBox)sender;

            if(e.NewValue == CheckState.Checked) // Urun secilmis ise
            {
                Urun SecilenUrun = checkedListBox.Items[e.Index] as Urun;
                pctBoxUrunResmi.Image = Image.FromFile(SecilenUrun.UrunResmi);
                txtBoxUrunAdi.Text = SecilenUrun.UrunAdi;
                txtBoxUrunKategorisi.Text = SecilenUrun.UrunKategorisi;
                txtBoxStokAdedi.Text = SecilenUrun.UrunStokAdedi.ToString();
                txtBoxYazar.Text = SecilenUrun.Yazar;
                rchTxtBoxUrunBilgisi.Text = SecilenUrun.UrunAciklamasi;
            }

            for (int i=0; i< chkListBox.Items.Count; i++)
            {
                if(i==e.Index)
                {

                }
                else
                {
                    chkListBox.SetItemChecked(i, false);
                }
            }
        }
    }
}
