
namespace NetFramework.S18.D91.CheckedListBoxKullanimi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkListBox = new System.Windows.Forms.CheckedListBox();
            this.grpboxUrunDetay = new System.Windows.Forms.GroupBox();
            this.txtBoxYazar = new System.Windows.Forms.TextBox();
            this.txtBoxStokAdedi = new System.Windows.Forms.TextBox();
            this.txtBoxUrunKategorisi = new System.Windows.Forms.TextBox();
            this.txtBoxUrunAdi = new System.Windows.Forms.TextBox();
            this.rchTxtBoxUrunBilgisi = new System.Windows.Forms.RichTextBox();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblStokAdedi = new System.Windows.Forms.Label();
            this.lblUrunKategorisi = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.pctBoxUrunResmi = new System.Windows.Forms.PictureBox();
            this.grpboxUrunDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxUrunResmi)).BeginInit();
            this.SuspendLayout();
            // 
            // chkListBox
            // 
            this.chkListBox.FormattingEnabled = true;
            this.chkListBox.Location = new System.Drawing.Point(25, 39);
            this.chkListBox.Name = "chkListBox";
            this.chkListBox.Size = new System.Drawing.Size(185, 379);
            this.chkListBox.TabIndex = 0;
            this.chkListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkBoxList_ItemCheck);
            // 
            // grpboxUrunDetay
            // 
            this.grpboxUrunDetay.Controls.Add(this.txtBoxYazar);
            this.grpboxUrunDetay.Controls.Add(this.txtBoxStokAdedi);
            this.grpboxUrunDetay.Controls.Add(this.txtBoxUrunKategorisi);
            this.grpboxUrunDetay.Controls.Add(this.txtBoxUrunAdi);
            this.grpboxUrunDetay.Controls.Add(this.rchTxtBoxUrunBilgisi);
            this.grpboxUrunDetay.Controls.Add(this.lblYazar);
            this.grpboxUrunDetay.Controls.Add(this.lblStokAdedi);
            this.grpboxUrunDetay.Controls.Add(this.lblUrunKategorisi);
            this.grpboxUrunDetay.Controls.Add(this.lblUrunAdi);
            this.grpboxUrunDetay.Controls.Add(this.pctBoxUrunResmi);
            this.grpboxUrunDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpboxUrunDetay.Location = new System.Drawing.Point(256, 39);
            this.grpboxUrunDetay.Name = "grpboxUrunDetay";
            this.grpboxUrunDetay.Size = new System.Drawing.Size(494, 387);
            this.grpboxUrunDetay.TabIndex = 4;
            this.grpboxUrunDetay.TabStop = false;
            this.grpboxUrunDetay.Text = "Secilen Urun Detay Bilgisi";
            // 
            // txtBoxYazar
            // 
            this.txtBoxYazar.Location = new System.Drawing.Point(295, 145);
            this.txtBoxYazar.Name = "txtBoxYazar";
            this.txtBoxYazar.Size = new System.Drawing.Size(156, 23);
            this.txtBoxYazar.TabIndex = 3;
            // 
            // txtBoxStokAdedi
            // 
            this.txtBoxStokAdedi.Location = new System.Drawing.Point(295, 113);
            this.txtBoxStokAdedi.Name = "txtBoxStokAdedi";
            this.txtBoxStokAdedi.Size = new System.Drawing.Size(156, 23);
            this.txtBoxStokAdedi.TabIndex = 2;
            // 
            // txtBoxUrunKategorisi
            // 
            this.txtBoxUrunKategorisi.Location = new System.Drawing.Point(295, 79);
            this.txtBoxUrunKategorisi.Name = "txtBoxUrunKategorisi";
            this.txtBoxUrunKategorisi.Size = new System.Drawing.Size(156, 23);
            this.txtBoxUrunKategorisi.TabIndex = 1;
            // 
            // txtBoxUrunAdi
            // 
            this.txtBoxUrunAdi.Location = new System.Drawing.Point(295, 49);
            this.txtBoxUrunAdi.Name = "txtBoxUrunAdi";
            this.txtBoxUrunAdi.Size = new System.Drawing.Size(156, 23);
            this.txtBoxUrunAdi.TabIndex = 0;
            // 
            // rchTxtBoxUrunBilgisi
            // 
            this.rchTxtBoxUrunBilgisi.Location = new System.Drawing.Point(6, 192);
            this.rchTxtBoxUrunBilgisi.Name = "rchTxtBoxUrunBilgisi";
            this.rchTxtBoxUrunBilgisi.Size = new System.Drawing.Size(445, 187);
            this.rchTxtBoxUrunBilgisi.TabIndex = 4;
            this.rchTxtBoxUrunBilgisi.Text = "";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazar.Location = new System.Drawing.Point(184, 145);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(45, 17);
            this.lblYazar.TabIndex = 7;
            this.lblYazar.Text = "Yazar";
            // 
            // lblStokAdedi
            // 
            this.lblStokAdedi.AutoSize = true;
            this.lblStokAdedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStokAdedi.Location = new System.Drawing.Point(184, 113);
            this.lblStokAdedi.Name = "lblStokAdedi";
            this.lblStokAdedi.Size = new System.Drawing.Size(76, 17);
            this.lblStokAdedi.TabIndex = 7;
            this.lblStokAdedi.Text = "Stok Adedi";
            // 
            // lblUrunKategorisi
            // 
            this.lblUrunKategorisi.AutoSize = true;
            this.lblUrunKategorisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunKategorisi.Location = new System.Drawing.Point(184, 82);
            this.lblUrunKategorisi.Name = "lblUrunKategorisi";
            this.lblUrunKategorisi.Size = new System.Drawing.Size(106, 17);
            this.lblUrunKategorisi.TabIndex = 5;
            this.lblUrunKategorisi.Text = "Urun Kategorisi";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.Location = new System.Drawing.Point(184, 49);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(63, 17);
            this.lblUrunAdi.TabIndex = 3;
            this.lblUrunAdi.Text = "Urun Adi";
            // 
            // pctBoxUrunResmi
            // 
            this.pctBoxUrunResmi.Location = new System.Drawing.Point(6, 35);
            this.pctBoxUrunResmi.Name = "pctBoxUrunResmi";
            this.pctBoxUrunResmi.Size = new System.Drawing.Size(158, 151);
            this.pctBoxUrunResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxUrunResmi.TabIndex = 3;
            this.pctBoxUrunResmi.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 445);
            this.Controls.Add(this.grpboxUrunDetay);
            this.Controls.Add(this.chkListBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checked List Box";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpboxUrunDetay.ResumeLayout(false);
            this.grpboxUrunDetay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxUrunResmi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkListBox;
        private System.Windows.Forms.GroupBox grpboxUrunDetay;
        private System.Windows.Forms.TextBox txtBoxYazar;
        private System.Windows.Forms.TextBox txtBoxStokAdedi;
        private System.Windows.Forms.TextBox txtBoxUrunKategorisi;
        private System.Windows.Forms.TextBox txtBoxUrunAdi;
        private System.Windows.Forms.RichTextBox rchTxtBoxUrunBilgisi;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label lblStokAdedi;
        private System.Windows.Forms.Label lblUrunKategorisi;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.PictureBox pctBoxUrunResmi;
    }
}

