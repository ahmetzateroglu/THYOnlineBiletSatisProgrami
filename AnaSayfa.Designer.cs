namespace THY
{
    partial class AnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.btnGirisEkrani = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtYolcuSayisi = new System.Windows.Forms.TextBox();
            this.lblYolcuSayisi = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cmbNereye = new System.Windows.Forms.ComboBox();
            this.cmbNerden = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKId = new System.Windows.Forms.Label();
            this.btnUcusDurumu = new System.Windows.Forms.Button();
            this.btnBilet = new System.Windows.Forms.Button();
            this.txtKAd = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGirisEkrani
            // 
            this.btnGirisEkrani.Location = new System.Drawing.Point(754, 16);
            this.btnGirisEkrani.Margin = new System.Windows.Forms.Padding(5);
            this.btnGirisEkrani.Name = "btnGirisEkrani";
            this.btnGirisEkrani.Size = new System.Drawing.Size(95, 35);
            this.btnGirisEkrani.TabIndex = 3;
            this.btnGirisEkrani.Text = "Giriş Yap";
            this.btnGirisEkrani.UseVisualStyleBackColor = true;
            this.btnGirisEkrani.Click += new System.EventHandler(this.btnGirisEkrani_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.txtYolcuSayisi);
            this.panel1.Controls.Add(this.lblYolcuSayisi);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.cmbNereye);
            this.panel1.Controls.Add(this.cmbNerden);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAra);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(39, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 249);
            this.panel1.TabIndex = 12;
            // 
            // txtYolcuSayisi
            // 
            this.txtYolcuSayisi.Location = new System.Drawing.Point(510, 60);
            this.txtYolcuSayisi.Name = "txtYolcuSayisi";
            this.txtYolcuSayisi.Size = new System.Drawing.Size(147, 26);
            this.txtYolcuSayisi.TabIndex = 19;
            this.txtYolcuSayisi.Text = "1";
            // 
            // lblYolcuSayisi
            // 
            this.lblYolcuSayisi.AutoSize = true;
            this.lblYolcuSayisi.Location = new System.Drawing.Point(524, 37);
            this.lblYolcuSayisi.Name = "lblYolcuSayisi";
            this.lblYolcuSayisi.Size = new System.Drawing.Size(111, 20);
            this.lblYolcuSayisi.TabIndex = 18;
            this.lblYolcuSayisi.Text = "Yolcu Sayısı:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(673, 64);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(100, 24);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Economy";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(673, 34);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(100, 24);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Business";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // cmbNereye
            // 
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Items.AddRange(new object[] {
            "Ankara Esenboğa Havalimanı (ESB), Ankara, Türkiye",
            "Erzurum Havalimanı (ERZ), Erzurum, Türkiye",
            "İstanbul Havalimanı (IST), İstanbul, Türkiye",
            "Sabiha Gökçen Havalimanı (SAW), İstanbul, Türkiye",
            "İzmir Adnan Menderes Havalimanı (ADB), İzmir, Türkiye",
            "Hatay Havalimanı (HTY), Hatay, Türkiye"});
            this.cmbNereye.Location = new System.Drawing.Point(178, 60);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(147, 28);
            this.cmbNereye.TabIndex = 15;
            // 
            // cmbNerden
            // 
            this.cmbNerden.FormattingEnabled = true;
            this.cmbNerden.Items.AddRange(new object[] {
            "Ankara Esenboğa Havalimanı (ESB), Ankara, Türkiye",
            "Erzurum Havalimanı (ERZ), Erzurum, Türkiye",
            "İstanbul Havalimanı (IST), İstanbul, Türkiye",
            "Sabiha Gökçen Havalimanı (SAW), İstanbul, Türkiye",
            "İzmir Adnan Menderes Havalimanı (ADB), İzmir, Türkiye",
            "Hatay Havalimanı (HTY), Hatay, Türkiye"});
            this.cmbNerden.Location = new System.Drawing.Point(13, 60);
            this.cmbNerden.Name = "cmbNerden";
            this.cmbNerden.Size = new System.Drawing.Size(147, 28);
            this.cmbNerden.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nerden:";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Red;
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(319, 112);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(131, 51);
            this.btnAra.TabIndex = 8;
            this.btnAra.Text = "Uçuş Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(343, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 26);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 18, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nereye:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tarih:";
            // 
            // lblKId
            // 
            this.lblKId.AutoSize = true;
            this.lblKId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKId.Location = new System.Drawing.Point(574, 61);
            this.lblKId.Name = "lblKId";
            this.lblKId.Size = new System.Drawing.Size(0, 25);
            this.lblKId.TabIndex = 14;
            this.lblKId.Visible = false;
            // 
            // btnUcusDurumu
            // 
            this.btnUcusDurumu.Location = new System.Drawing.Point(207, 137);
            this.btnUcusDurumu.Margin = new System.Windows.Forms.Padding(5);
            this.btnUcusDurumu.Name = "btnUcusDurumu";
            this.btnUcusDurumu.Size = new System.Drawing.Size(138, 35);
            this.btnUcusDurumu.TabIndex = 15;
            this.btnUcusDurumu.Text = "Uçuş Durumu";
            this.btnUcusDurumu.UseVisualStyleBackColor = true;
            this.btnUcusDurumu.Click += new System.EventHandler(this.btnUcusDurumu_Click);
            // 
            // btnBilet
            // 
            this.btnBilet.Location = new System.Drawing.Point(43, 137);
            this.btnBilet.Margin = new System.Windows.Forms.Padding(5);
            this.btnBilet.Name = "btnBilet";
            this.btnBilet.Size = new System.Drawing.Size(138, 35);
            this.btnBilet.TabIndex = 16;
            this.btnBilet.Text = "Bilet Yönetimi";
            this.btnBilet.UseVisualStyleBackColor = true;
            this.btnBilet.Click += new System.EventHandler(this.btnBilet_Click);
            // 
            // txtKAd
            // 
            this.txtKAd.BackColor = System.Drawing.Color.White;
            this.txtKAd.Location = new System.Drawing.Point(319, 25);
            this.txtKAd.Margin = new System.Windows.Forms.Padding(8);
            this.txtKAd.Name = "txtKAd";
            this.txtKAd.ReadOnly = true;
            this.txtKAd.Size = new System.Drawing.Size(221, 26);
            this.txtKAd.TabIndex = 18;
            this.txtKAd.Text = "Hoşgeldin";
            this.txtKAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.txtKAd);
            this.panel2.Controls.Add(this.btnGirisEkrani);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 72);
            this.panel2.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(544, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "TURKISH AIRLINES";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBilet);
            this.Controls.Add(this.btnUcusDurumu);
            this.Controls.Add(this.lblKId);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaSayfa_FormClosing);
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGirisEkrani;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbNereye;
        private System.Windows.Forms.ComboBox cmbNerden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYolcuSayisi;
        private System.Windows.Forms.Label lblYolcuSayisi;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.Label lblKId;
        private System.Windows.Forms.Button btnUcusDurumu;
        private System.Windows.Forms.Button btnBilet;
        public System.Windows.Forms.TextBox txtKAd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

