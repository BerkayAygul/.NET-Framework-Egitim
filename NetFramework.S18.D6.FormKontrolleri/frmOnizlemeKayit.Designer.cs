namespace NetFramework.S18.D6.FormKontrolleri
{
    partial class frmOnizlemeKayit
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
            this.lblTelefonNo = new System.Windows.Forms.Label();
            this.lblEmailAdres = new System.Windows.Forms.Label();
            this.lblSoyIsim = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.txtEmailAdres = new System.Windows.Forms.TextBox();
            this.txtSoyIsim = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTelefonNo
            // 
            this.lblTelefonNo.AutoSize = true;
            this.lblTelefonNo.Location = new System.Drawing.Point(20, 91);
            this.lblTelefonNo.Name = "lblTelefonNo";
            this.lblTelefonNo.Size = new System.Drawing.Size(60, 13);
            this.lblTelefonNo.TabIndex = 6;
            this.lblTelefonNo.Text = "Telefon No";
            // 
            // lblEmailAdres
            // 
            this.lblEmailAdres.AutoSize = true;
            this.lblEmailAdres.Location = new System.Drawing.Point(20, 65);
            this.lblEmailAdres.Name = "lblEmailAdres";
            this.lblEmailAdres.Size = new System.Drawing.Size(65, 13);
            this.lblEmailAdres.TabIndex = 7;
            this.lblEmailAdres.Text = "E-mail Adres";
            // 
            // lblSoyIsim
            // 
            this.lblSoyIsim.AutoSize = true;
            this.lblSoyIsim.Location = new System.Drawing.Point(20, 39);
            this.lblSoyIsim.Name = "lblSoyIsim";
            this.lblSoyIsim.Size = new System.Drawing.Size(43, 13);
            this.lblSoyIsim.TabIndex = 8;
            this.lblSoyIsim.Text = "SoyIsim";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(20, 15);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(25, 13);
            this.lblIsim.TabIndex = 9;
            this.lblIsim.Text = "Isim";
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Enabled = false;
            this.txtTelefonNo.Location = new System.Drawing.Point(98, 88);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(207, 20);
            this.txtTelefonNo.TabIndex = 11;
            // 
            // txtEmailAdres
            // 
            this.txtEmailAdres.Enabled = false;
            this.txtEmailAdres.Location = new System.Drawing.Point(98, 62);
            this.txtEmailAdres.Name = "txtEmailAdres";
            this.txtEmailAdres.Size = new System.Drawing.Size(207, 20);
            this.txtEmailAdres.TabIndex = 10;
            // 
            // txtSoyIsim
            // 
            this.txtSoyIsim.Enabled = false;
            this.txtSoyIsim.Location = new System.Drawing.Point(98, 36);
            this.txtSoyIsim.Name = "txtSoyIsim";
            this.txtSoyIsim.Size = new System.Drawing.Size(207, 20);
            this.txtSoyIsim.TabIndex = 5;
            // 
            // txtIsim
            // 
            this.txtIsim.Enabled = false;
            this.txtIsim.Location = new System.Drawing.Point(98, 12);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(207, 20);
            this.txtIsim.TabIndex = 4;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(311, 10);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(86, 98);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmOnizlemeKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 129);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblTelefonNo);
            this.Controls.Add(this.lblEmailAdres);
            this.Controls.Add(this.lblSoyIsim);
            this.Controls.Add(this.lblIsim);
            this.Controls.Add(this.txtTelefonNo);
            this.Controls.Add(this.txtEmailAdres);
            this.Controls.Add(this.txtSoyIsim);
            this.Controls.Add(this.txtIsim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOnizlemeKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Onizleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTelefonNo;
        private System.Windows.Forms.Label lblEmailAdres;
        private System.Windows.Forms.Label lblSoyIsim;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.TextBox txtEmailAdres;
        private System.Windows.Forms.TextBox txtSoyIsim;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Button btnKaydet;
    }
}