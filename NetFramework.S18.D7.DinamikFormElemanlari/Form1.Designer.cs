namespace NetFramework.S18.D7.DinamikFormElemanlari
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
            this.btnUret = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSkor1 = new System.Windows.Forms.Label();
            this.lblMayin1 = new System.Windows.Forms.Label();
            this.lblMayin2 = new System.Windows.Forms.Label();
            this.lblSkor2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(339, 217);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(189, 156);
            this.btnUret.TabIndex = 0;
            this.btnUret.Text = "Uret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(332, 370);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // lblSkor1
            // 
            this.lblSkor1.AutoSize = true;
            this.lblSkor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor1.Location = new System.Drawing.Point(360, 99);
            this.lblSkor1.Name = "lblSkor1";
            this.lblSkor1.Size = new System.Drawing.Size(48, 24);
            this.lblSkor1.TabIndex = 2;
            this.lblSkor1.Text = "Skor";
            // 
            // lblMayin1
            // 
            this.lblMayin1.AutoSize = true;
            this.lblMayin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMayin1.Location = new System.Drawing.Point(360, 137);
            this.lblMayin1.Name = "lblMayin1";
            this.lblMayin1.Size = new System.Drawing.Size(60, 24);
            this.lblMayin1.TabIndex = 2;
            this.lblMayin1.Text = "Mayin";
            // 
            // lblMayin2
            // 
            this.lblMayin2.AutoSize = true;
            this.lblMayin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMayin2.Location = new System.Drawing.Point(429, 137);
            this.lblMayin2.Name = "lblMayin2";
            this.lblMayin2.Size = new System.Drawing.Size(60, 24);
            this.lblMayin2.TabIndex = 3;
            this.lblMayin2.Text = "Mayin";
            // 
            // lblSkor2
            // 
            this.lblSkor2.AutoSize = true;
            this.lblSkor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor2.Location = new System.Drawing.Point(429, 99);
            this.lblSkor2.Name = "lblSkor2";
            this.lblSkor2.Size = new System.Drawing.Size(48, 24);
            this.lblSkor2.TabIndex = 4;
            this.lblSkor2.Text = "Skor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 378);
            this.Controls.Add(this.lblSkor2);
            this.Controls.Add(this.lblMayin2);
            this.Controls.Add(this.lblMayin1);
            this.Controls.Add(this.lblSkor1);
            this.Controls.Add(this.btnUret);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Dinamik Form Elemani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblSkor1;
        private System.Windows.Forms.Label lblMayin1;
        private System.Windows.Forms.Label lblMayin2;
        private System.Windows.Forms.Label lblSkor2;
    }
}

