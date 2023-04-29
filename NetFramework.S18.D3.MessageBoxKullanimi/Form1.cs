using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D3.MessageBoxKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kullaniciya Gosterilmek Istenilen Mesaj", "Baslik",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            DialogResult Cevap = MessageBox.Show("Soru Mesaji", "Baslik", MessageBoxButtons.YesNoCancel, 
                                                                    MessageBoxIcon.Question);

            if (Cevap == DialogResult.Yes)
            {

            }
            else if (Cevap == DialogResult.No)
            {

            }
            else if (Cevap == DialogResult.Cancel)
            {

            }
        }
    }
}
