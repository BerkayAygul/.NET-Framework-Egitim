using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D5.ShowDialogKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            MusteriKayit F2 = new MusteriKayit();

            F2.Show();
        }

        private void btnGosterPopup_Click(object sender, EventArgs e)
        {
            MusteriKayit F2 = new MusteriKayit();

            F2.ShowDialog();
        }
    }
}
