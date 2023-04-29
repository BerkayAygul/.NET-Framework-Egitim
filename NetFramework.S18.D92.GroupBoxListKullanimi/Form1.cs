using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D92.GroupBoxListKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int SayacLabel = 0;
            int SayacTextBox = 0;
            int SayacGroupBox = 0;
            foreach (Control item in this.Controls)
            {
                if(item is Label)
                {
                    SayacLabel++;
                }
                else if(item is TextBox)
                {
                    SayacTextBox++;
                }
                else if(item is GroupBox)
                {
                    SayacGroupBox++;
                }
            }

            GroupBox GpBox = this.Controls["GrpBoxMusteriBilgileri"] as GroupBox;

            foreach (var item in GpBox.Controls)
            {
                item.GetType();
            }
        }
    }
}
