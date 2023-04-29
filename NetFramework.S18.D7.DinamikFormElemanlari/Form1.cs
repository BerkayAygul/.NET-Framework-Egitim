using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D7.DinamikFormElemanlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblSkor2.Text = "0";
            lblMayin2.Text = "0";
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            int Mayin1 = 0;
            int Mayin2 = 0;
            int Mayin3 = 0;

            Random rnd = new Random();
            Mayin1 = rnd.Next(1, 20);
            Mayin2 = rnd.Next(21, 40);
            Mayin3 = rnd.Next(41, 50);

            for (int i = 1; i<=50; i++)
            {
                Button btnTemp = new Button();

                btnTemp.Name = "btnUretilenButon" + i.ToString();
                btnTemp.Text = i.ToString();
                btnTemp.Size = new System.Drawing.Size(35, 35);
                btnTemp.UseVisualStyleBackColor = true;

                if(Mayin1 == i || Mayin2 == i || Mayin3 == i)
                {
                    btnTemp.Tag = true;
                }
                else
                {
                    btnTemp.Tag = false;
                }

                btnTemp.Click += btnTemp_Click;

                flowLayoutPanel1.Controls.Add(btnTemp);

            }
        }
        private void btnTemp_Click(object sender, EventArgs e)
        {
            Button BasilanButton = (Button)sender;
            bool MayinKontrol = (bool)BasilanButton.Tag;

            if(MayinKontrol)
            {
                MessageBox.Show("Mayin bulundu");
                BasilanButton.BackColor = Color.Red;
                int Mayinint = int.Parse(lblMayin2.Text);
                Mayinint++;
                lblSkor2.Text = Mayinint.ToString();
            }
            else
            {
                BasilanButton.BackColor = Color.Green;

                int Skorint = int.Parse(lblSkor2.Text);
                Skorint++;
                lblSkor2.Text = Skorint.ToString();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

/*
            this.btnTemp.Location = new System.Drawing.Point(3, 3);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(35, 35);
            this.btnTemp.TabIndex = 0;
            this.btnTemp.Text = "1";
            this.btnTemp.UseVisualStyleBackColor = true;
*/
