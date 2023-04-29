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
    public partial class Form2 : Form
    {
        public Form2(string MetinAl)
        {
            InitializeComponent();

            Mesaj2.Text = MetinAl;
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
