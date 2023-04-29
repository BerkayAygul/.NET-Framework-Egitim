using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D1.WindowsFormsKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Mesaj1.Text = "Metni Giriniz: ";
        }

        private void ButtonAc_Click(object sender, EventArgs e)
        {
            string TextMesajDegeri = Mesaj1.Text;

            Form2 YeniForm = new Form2(TextMesajDegeri);

            YeniForm.Show();
        }

        private void Mesaj1_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;

            T1.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Mesaj1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
