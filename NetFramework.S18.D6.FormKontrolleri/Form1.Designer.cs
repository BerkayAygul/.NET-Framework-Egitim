namespace NetFramework.S18.D6.FormKontrolleri
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.lblIsim = new System.Windows.Forms.Label();
            this.txtSoyIsim = new System.Windows.Forms.TextBox();
            this.lblSoyIsim = new System.Windows.Forms.Label();
            this.txtEmailAdres = new System.Windows.Forms.TextBox();
            this.lblEmailAdres = new System.Windows.Forms.Label();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.lblTelefonNo = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnOnizleme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(263, 152);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(102, 37);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(158, 50);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(207, 20);
            this.txtIsim.TabIndex = 0;
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(80, 53);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(25, 13);
            this.lblIsim.TabIndex = 2;
            this.lblIsim.Text = "Isim";
            // 
            // txtSoyIsim
            // 
            this.txtSoyIsim.Location = new System.Drawing.Point(158, 74);
            this.txtSoyIsim.Name = "txtSoyIsim";
            this.txtSoyIsim.Size = new System.Drawing.Size(207, 20);
            this.txtSoyIsim.TabIndex = 1;
            // 
            // lblSoyIsim
            // 
            this.lblSoyIsim.AutoSize = true;
            this.lblSoyIsim.Location = new System.Drawing.Point(80, 77);
            this.lblSoyIsim.Name = "lblSoyIsim";
            this.lblSoyIsim.Size = new System.Drawing.Size(43, 13);
            this.lblSoyIsim.TabIndex = 2;
            this.lblSoyIsim.Text = "SoyIsim";
            // 
            // txtEmailAdres
            // 
            this.txtEmailAdres.Location = new System.Drawing.Point(158, 100);
            this.txtEmailAdres.Name = "txtEmailAdres";
            this.txtEmailAdres.Size = new System.Drawing.Size(207, 20);
            this.txtEmailAdres.TabIndex = 2;
            // 
            // lblEmailAdres
            // 
            this.lblEmailAdres.AutoSize = true;
            this.lblEmailAdres.Location = new System.Drawing.Point(80, 103);
            this.lblEmailAdres.Name = "lblEmailAdres";
            this.lblEmailAdres.Size = new System.Drawing.Size(65, 13);
            this.lblEmailAdres.TabIndex = 2;
            this.lblEmailAdres.Text = "E-mail Adres";
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(158, 126);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(207, 20);
            this.txtTelefonNo.TabIndex = 3;
            // 
            // lblTelefonNo
            // 
            this.lblTelefonNo.AutoSize = true;
            this.lblTelefonNo.Location = new System.Drawing.Point(80, 129);
            this.lblTelefonNo.Name = "lblTelefonNo";
            this.lblTelefonNo.Size = new System.Drawing.Size(60, 13);
            this.lblTelefonNo.TabIndex = 2;
            this.lblTelefonNo.Text = "Telefon No";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(158, 152);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(102, 37);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnOnizleme
            // 
            this.btnOnizleme.Location = new System.Drawing.Point(158, 195);
            this.btnOnizleme.Name = "btnOnizleme";
            this.btnOnizleme.Size = new System.Drawing.Size(207, 38);
            this.btnOnizleme.TabIndex = 6;
            this.btnOnizleme.Text = "Kayit Onizleme";
            this.btnOnizleme.UseVisualStyleBackColor = true;
            this.btnOnizleme.Click += new System.EventHandler(this.btnOnizleme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 293);
            this.Controls.Add(this.btnOnizleme);
            this.Controls.Add(this.lblTelefonNo);
            this.Controls.Add(this.lblEmailAdres);
            this.Controls.Add(this.lblSoyIsim);
            this.Controls.Add(this.lblIsim);
            this.Controls.Add(this.txtTelefonNo);
            this.Controls.Add(this.txtEmailAdres);
            this.Controls.Add(this.txtSoyIsim);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteri Kayit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.TextBox txtSoyIsim;
        private System.Windows.Forms.Label lblSoyIsim;
        private System.Windows.Forms.TextBox txtEmailAdres;
        private System.Windows.Forms.Label lblEmailAdres;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.Label lblTelefonNo;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnOnizleme;
    }
}

