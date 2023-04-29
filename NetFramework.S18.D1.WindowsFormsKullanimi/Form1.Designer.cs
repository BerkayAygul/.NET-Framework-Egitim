namespace NetFramework.S18.D1.WindowsFormsKullanimi
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
            this.ButtonAc = new System.Windows.Forms.Button();
            this.Mesaj1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonAc
            // 
            this.ButtonAc.Location = new System.Drawing.Point(59, 67);
            this.ButtonAc.Name = "ButtonAc";
            this.ButtonAc.Size = new System.Drawing.Size(167, 59);
            this.ButtonAc.TabIndex = 0;
            this.ButtonAc.Text = "Yeni Form Ac";
            this.ButtonAc.UseVisualStyleBackColor = true;
            this.ButtonAc.Click += new System.EventHandler(this.ButtonAc_Click);
            // 
            // Mesaj1
            // 
            this.Mesaj1.Location = new System.Drawing.Point(59, 41);
            this.Mesaj1.Name = "Mesaj1";
            this.Mesaj1.Size = new System.Drawing.Size(167, 20);
            this.Mesaj1.TabIndex = 1;
            this.Mesaj1.TextChanged += new System.EventHandler(this.Mesaj1_TextChanged);
            this.Mesaj1.Enter += new System.EventHandler(this.Mesaj1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ikinci Form uzerinde yazmasini istediginiz \r\nmetni giriniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 138);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mesaj1);
            this.Controls.Add(this.ButtonAc);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAc;
        private System.Windows.Forms.TextBox Mesaj1;
        private System.Windows.Forms.Label label1;
    }
}

