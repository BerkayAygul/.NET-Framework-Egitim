namespace NetFramework.S18.D8.ComboBoxKullanimi
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
            this.lblUrunListesi = new System.Windows.Forms.Label();
            this.cmbBoxUrunListesi = new System.Windows.Forms.ComboBox();
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
            // lblUrunListesi
            // 
            this.lblUrunListesi.AutoSize = true;
            this.lblUrunListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunListesi.Location = new System.Drawing.Point(61, 24);
            this.lblUrunListesi.Name = "lblUrunListesi";
            this.lblUrunListesi.Size = new System.Drawing.Size(83, 17);
            this.lblUrunListesi.TabIndex = 0;
            this.lblUrunListesi.Text = "Urun Listesi";
            // 
            // cmbBoxUrunListesi
            // 
            this.cmbBoxUrunListesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxUrunListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxUrunListesi.FormattingEnabled = true;
            this.cmbBoxUrunListesi.Location = new System.Drawing.Point(197, 21);
            this.cmbBoxUrunListesi.Name = "cmbBoxUrunListesi";
            this.cmbBoxUrunListesi.Size = new System.Drawing.Size(288, 24);
            this.cmbBoxUrunListesi.TabIndex = 0;
            this.cmbBoxUrunListesi.SelectedIndexChanged += new System.EventHandler(this.cmbBoxUrunListesi_SelectedIndexChanged);
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
            this.grpboxUrunDetay.Location = new System.Drawing.Point(54, 90);
            this.grpboxUrunDetay.Name = "grpboxUrunDetay";
            this.grpboxUrunDetay.Size = new System.Drawing.Size(456, 445);
            this.grpboxUrunDetay.TabIndex = 2;
            this.grpboxUrunDetay.TabStop = false;
            this.grpboxUrunDetay.Text = "Secilen Urun Detay Bilgisi";
            // 
            // txtBoxYazar
            // 
            this.txtBoxYazar.Location = new System.Drawing.Point(275, 127);
            this.txtBoxYazar.Name = "txtBoxYazar";
            this.txtBoxYazar.Size = new System.Drawing.Size(156, 23);
            this.txtBoxYazar.TabIndex = 3;
            // 
            // txtBoxStokAdedi
            // 
            this.txtBoxStokAdedi.Location = new System.Drawing.Point(275, 95);
            this.txtBoxStokAdedi.Name = "txtBoxStokAdedi";
            this.txtBoxStokAdedi.Size = new System.Drawing.Size(156, 23);
            this.txtBoxStokAdedi.TabIndex = 2;
            // 
            // txtBoxUrunKategorisi
            // 
            this.txtBoxUrunKategorisi.Location = new System.Drawing.Point(275, 61);
            this.txtBoxUrunKategorisi.Name = "txtBoxUrunKategorisi";
            this.txtBoxUrunKategorisi.Size = new System.Drawing.Size(156, 23);
            this.txtBoxUrunKategorisi.TabIndex = 1;
            // 
            // txtBoxUrunAdi
            // 
            this.txtBoxUrunAdi.Location = new System.Drawing.Point(275, 31);
            this.txtBoxUrunAdi.Name = "txtBoxUrunAdi";
            this.txtBoxUrunAdi.Size = new System.Drawing.Size(156, 23);
            this.txtBoxUrunAdi.TabIndex = 0;
            // 
            // rchTxtBoxUrunBilgisi
            // 
            this.rchTxtBoxUrunBilgisi.Location = new System.Drawing.Point(-1, 186);
            this.rchTxtBoxUrunBilgisi.Name = "rchTxtBoxUrunBilgisi";
            this.rchTxtBoxUrunBilgisi.Size = new System.Drawing.Size(432, 253);
            this.rchTxtBoxUrunBilgisi.TabIndex = 4;
            this.rchTxtBoxUrunBilgisi.Text = "";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazar.Location = new System.Drawing.Point(164, 127);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(45, 17);
            this.lblYazar.TabIndex = 7;
            this.lblYazar.Text = "Yazar";
            // 
            // lblStokAdedi
            // 
            this.lblStokAdedi.AutoSize = true;
            this.lblStokAdedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStokAdedi.Location = new System.Drawing.Point(164, 95);
            this.lblStokAdedi.Name = "lblStokAdedi";
            this.lblStokAdedi.Size = new System.Drawing.Size(76, 17);
            this.lblStokAdedi.TabIndex = 7;
            this.lblStokAdedi.Text = "Stok Adedi";
            // 
            // lblUrunKategorisi
            // 
            this.lblUrunKategorisi.AutoSize = true;
            this.lblUrunKategorisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunKategorisi.Location = new System.Drawing.Point(164, 64);
            this.lblUrunKategorisi.Name = "lblUrunKategorisi";
            this.lblUrunKategorisi.Size = new System.Drawing.Size(106, 17);
            this.lblUrunKategorisi.TabIndex = 5;
            this.lblUrunKategorisi.Text = "Urun Kategorisi";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.Location = new System.Drawing.Point(164, 31);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(63, 17);
            this.lblUrunAdi.TabIndex = 3;
            this.lblUrunAdi.Text = "Urun Adi";
            // 
            // pctBoxUrunResmi
            // 
            this.pctBoxUrunResmi.Location = new System.Drawing.Point(0, 29);
            this.pctBoxUrunResmi.Name = "pctBoxUrunResmi";
            this.pctBoxUrunResmi.Size = new System.Drawing.Size(158, 151);
            this.pctBoxUrunResmi.TabIndex = 3;
            this.pctBoxUrunResmi.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 554);
            this.Controls.Add(this.grpboxUrunDetay);
            this.Controls.Add(this.cmbBoxUrunListesi);
            this.Controls.Add(this.lblUrunListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox Inceleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpboxUrunDetay.ResumeLayout(false);
            this.grpboxUrunDetay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxUrunResmi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrunListesi;
        private System.Windows.Forms.ComboBox cmbBoxUrunListesi;
        private System.Windows.Forms.GroupBox grpboxUrunDetay;
        private System.Windows.Forms.Label lblStokAdedi;
        private System.Windows.Forms.Label lblUrunKategorisi;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.PictureBox pctBoxUrunResmi;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.RichTextBox rchTxtBoxUrunBilgisi;
        private System.Windows.Forms.TextBox txtBoxYazar;
        private System.Windows.Forms.TextBox txtBoxStokAdedi;
        private System.Windows.Forms.TextBox txtBoxUrunKategorisi;
        private System.Windows.Forms.TextBox txtBoxUrunAdi;
    }
}

