namespace THY
{
    partial class Yonetici
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnUcus = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.btnKOnayla = new System.Windows.Forms.Button();
            this.btnAOnayla = new System.Windows.Forms.Button();
            this.btnYOnayla = new System.Windows.Forms.Button();
            this.btnSatisGor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yönetici";
            // 
            // btnUcus
            // 
            this.btnUcus.Location = new System.Drawing.Point(161, 112);
            this.btnUcus.Name = "btnUcus";
            this.btnUcus.Size = new System.Drawing.Size(148, 52);
            this.btnUcus.TabIndex = 2;
            this.btnUcus.Text = "Uçuş Ekle";
            this.btnUcus.UseVisualStyleBackColor = true;
            this.btnUcus.Click += new System.EventHandler(this.btnUcus_Click);
            // 
            // btngeri
            // 
            this.btngeri.Location = new System.Drawing.Point(12, 436);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(105, 43);
            this.btngeri.TabIndex = 3;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btnKOnayla
            // 
            this.btnKOnayla.Location = new System.Drawing.Point(343, 112);
            this.btnKOnayla.Name = "btnKOnayla";
            this.btnKOnayla.Size = new System.Drawing.Size(148, 52);
            this.btnKOnayla.TabIndex = 4;
            this.btnKOnayla.Text = "Kullanıcı Onayla";
            this.btnKOnayla.UseVisualStyleBackColor = true;
            this.btnKOnayla.Click += new System.EventHandler(this.btnKOnayla_Click);
            // 
            // btnAOnayla
            // 
            this.btnAOnayla.Location = new System.Drawing.Point(252, 204);
            this.btnAOnayla.Name = "btnAOnayla";
            this.btnAOnayla.Size = new System.Drawing.Size(148, 52);
            this.btnAOnayla.TabIndex = 5;
            this.btnAOnayla.Text = "Admin Onayla";
            this.btnAOnayla.UseVisualStyleBackColor = true;
            this.btnAOnayla.Click += new System.EventHandler(this.btnAOnayla_Click);
            // 
            // btnYOnayla
            // 
            this.btnYOnayla.Location = new System.Drawing.Point(432, 204);
            this.btnYOnayla.Name = "btnYOnayla";
            this.btnYOnayla.Size = new System.Drawing.Size(148, 52);
            this.btnYOnayla.TabIndex = 6;
            this.btnYOnayla.Text = "Yönetici Onayla";
            this.btnYOnayla.UseVisualStyleBackColor = true;
            this.btnYOnayla.Click += new System.EventHandler(this.btnYOnayla_Click);
            // 
            // btnSatisGor
            // 
            this.btnSatisGor.Location = new System.Drawing.Point(523, 112);
            this.btnSatisGor.Name = "btnSatisGor";
            this.btnSatisGor.Size = new System.Drawing.Size(148, 52);
            this.btnSatisGor.TabIndex = 7;
            this.btnSatisGor.Text = "Satışları Gör";
            this.btnSatisGor.UseVisualStyleBackColor = true;
            this.btnSatisGor.Click += new System.EventHandler(this.btnSatisGor_Click);
            // 
            // Yonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 491);
            this.Controls.Add(this.btnSatisGor);
            this.Controls.Add(this.btnYOnayla);
            this.Controls.Add(this.btnAOnayla);
            this.Controls.Add(this.btnKOnayla);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnUcus);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Yonetici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yonetici";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Yonetici_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUcus;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btnKOnayla;
        private System.Windows.Forms.Button btnAOnayla;
        private System.Windows.Forms.Button btnYOnayla;
        private System.Windows.Forms.Button btnSatisGor;
    }
}