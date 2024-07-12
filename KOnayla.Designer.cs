namespace THY
{
    partial class KOnayla
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblKullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHYDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHYDataSet = new THY.THYDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSecOnayla = new System.Windows.Forms.TextBox();
            this.btnSecOnayla = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSecSil = new System.Windows.Forms.TextBox();
            this.btnSecSil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSecOnayKaldir = new System.Windows.Forms.TextBox();
            this.btnSecOnayKaldir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_KullaniciTableAdapter = new THY.THYDataSetTableAdapters.Tbl_KullaniciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHYDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHYDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(830, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tblKullaniciBindingSource
            // 
            this.tblKullaniciBindingSource.DataMember = "Tbl_Kullanici";
            this.tblKullaniciBindingSource.DataSource = this.tHYDataSetBindingSource;
            // 
            // tHYDataSetBindingSource
            // 
            this.tHYDataSetBindingSource.DataSource = this.tHYDataSet;
            this.tHYDataSetBindingSource.Position = 0;
            // 
            // tHYDataSet
            // 
            this.tHYDataSet.DataSetName = "THYDataSet";
            this.tHYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.txtSecOnayla);
            this.panel1.Controls.Add(this.btnSecOnayla);
            this.panel1.Location = new System.Drawing.Point(75, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 235);
            this.panel1.TabIndex = 14;
            // 
            // txtSecOnayla
            // 
            this.txtSecOnayla.Location = new System.Drawing.Point(19, 20);
            this.txtSecOnayla.Multiline = true;
            this.txtSecOnayla.Name = "txtSecOnayla";
            this.txtSecOnayla.ReadOnly = true;
            this.txtSecOnayla.Size = new System.Drawing.Size(178, 109);
            this.txtSecOnayla.TabIndex = 13;
            this.txtSecOnayla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSecOnayla
            // 
            this.btnSecOnayla.BackColor = System.Drawing.Color.White;
            this.btnSecOnayla.Location = new System.Drawing.Point(49, 163);
            this.btnSecOnayla.Name = "btnSecOnayla";
            this.btnSecOnayla.Size = new System.Drawing.Size(110, 50);
            this.btnSecOnayla.TabIndex = 10;
            this.btnSecOnayla.Text = "Onayla";
            this.btnSecOnayla.UseCompatibleTextRendering = true;
            this.btnSecOnayla.UseVisualStyleBackColor = false;
            this.btnSecOnayla.Click += new System.EventHandler(this.btnSecOnayla_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(12, 438);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(82, 41);
            this.btnGeri.TabIndex = 15;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseCompatibleTextRendering = true;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.txtSecSil);
            this.panel3.Controls.Add(this.btnSecSil);
            this.panel3.Location = new System.Drawing.Point(565, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 235);
            this.panel3.TabIndex = 16;
            // 
            // txtSecSil
            // 
            this.txtSecSil.Location = new System.Drawing.Point(18, 20);
            this.txtSecSil.Multiline = true;
            this.txtSecSil.Name = "txtSecSil";
            this.txtSecSil.ReadOnly = true;
            this.txtSecSil.Size = new System.Drawing.Size(178, 109);
            this.txtSecSil.TabIndex = 13;
            this.txtSecSil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSecSil
            // 
            this.btnSecSil.BackColor = System.Drawing.Color.White;
            this.btnSecSil.Location = new System.Drawing.Point(55, 163);
            this.btnSecSil.Name = "btnSecSil";
            this.btnSecSil.Size = new System.Drawing.Size(110, 50);
            this.btnSecSil.TabIndex = 10;
            this.btnSecSil.Text = "Sil";
            this.btnSecSil.UseVisualStyleBackColor = false;
            this.btnSecSil.Click += new System.EventHandler(this.btnSecSil_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.txtSecOnayKaldir);
            this.panel2.Controls.Add(this.btnSecOnayKaldir);
            this.panel2.Location = new System.Drawing.Point(321, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 235);
            this.panel2.TabIndex = 15;
            // 
            // txtSecOnayKaldir
            // 
            this.txtSecOnayKaldir.Location = new System.Drawing.Point(20, 20);
            this.txtSecOnayKaldir.Multiline = true;
            this.txtSecOnayKaldir.Name = "txtSecOnayKaldir";
            this.txtSecOnayKaldir.ReadOnly = true;
            this.txtSecOnayKaldir.Size = new System.Drawing.Size(178, 109);
            this.txtSecOnayKaldir.TabIndex = 13;
            this.txtSecOnayKaldir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSecOnayKaldir
            // 
            this.btnSecOnayKaldir.BackColor = System.Drawing.Color.White;
            this.btnSecOnayKaldir.Location = new System.Drawing.Point(59, 163);
            this.btnSecOnayKaldir.Name = "btnSecOnayKaldir";
            this.btnSecOnayKaldir.Size = new System.Drawing.Size(110, 50);
            this.btnSecOnayKaldir.TabIndex = 10;
            this.btnSecOnayKaldir.Text = "Onay Kaldır";
            this.btnSecOnayKaldir.UseCompatibleTextRendering = true;
            this.btnSecOnayKaldir.UseVisualStyleBackColor = false;
            this.btnSecOnayKaldir.Click += new System.EventHandler(this.btnSecOnayKaldir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(385, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            // 
            // tbl_KullaniciTableAdapter
            // 
            this.tbl_KullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // KOnayla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "KOnayla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KOnayla";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KOnayla_FormClosing);
            this.Load += new System.EventHandler(this.KOnayla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHYDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHYDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
      
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSecOnayla;
        private System.Windows.Forms.Button btnSecOnayla;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSecSil;
        private System.Windows.Forms.Button btnSecSil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSecOnayKaldir;
        private System.Windows.Forms.Button btnSecOnayKaldir;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tHYDataSetBindingSource;
        private THYDataSet tHYDataSet;
        private System.Windows.Forms.BindingSource tblKullaniciBindingSource;
        private THYDataSetTableAdapters.Tbl_KullaniciTableAdapter tbl_KullaniciTableAdapter;
    }
}