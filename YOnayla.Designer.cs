namespace THY
{
    partial class YOnayla
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSecOnayKaldir = new System.Windows.Forms.TextBox();
            this.btnSecOnayKaldir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSecSil = new System.Windows.Forms.TextBox();
            this.btnSecSil = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSecOnayla = new System.Windows.Forms.TextBox();
            this.btnSecOnayla = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblYoneticiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHYDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHYDataSet = new THY.THYDataSet();
            this.tbl_YoneticiTableAdapter = new THY.THYDataSetTableAdapters.Tbl_YoneticiTableAdapter();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblYoneticiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHYDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHYDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.txtSecOnayKaldir);
            this.panel2.Controls.Add(this.btnSecOnayKaldir);
            this.panel2.Location = new System.Drawing.Point(323, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 241);
            this.panel2.TabIndex = 24;
            // 
            // txtSecOnayKaldir
            // 
            this.txtSecOnayKaldir.Location = new System.Drawing.Point(16, 21);
            this.txtSecOnayKaldir.Multiline = true;
            this.txtSecOnayKaldir.Name = "txtSecOnayKaldir";
            this.txtSecOnayKaldir.ReadOnly = true;
            this.txtSecOnayKaldir.Size = new System.Drawing.Size(178, 135);
            this.txtSecOnayKaldir.TabIndex = 13;
            this.txtSecOnayKaldir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSecOnayKaldir
            // 
            this.btnSecOnayKaldir.BackColor = System.Drawing.Color.White;
            this.btnSecOnayKaldir.Location = new System.Drawing.Point(52, 173);
            this.btnSecOnayKaldir.Name = "btnSecOnayKaldir";
            this.btnSecOnayKaldir.Size = new System.Drawing.Size(108, 51);
            this.btnSecOnayKaldir.TabIndex = 10;
            this.btnSecOnayKaldir.Text = "Onay Kaldır";
            this.btnSecOnayKaldir.UseCompatibleTextRendering = true;
            this.btnSecOnayKaldir.UseVisualStyleBackColor = false;
            this.btnSecOnayKaldir.Click += new System.EventHandler(this.btnSecOnayKaldir_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.txtSecSil);
            this.panel3.Controls.Add(this.btnSecSil);
            this.panel3.Location = new System.Drawing.Point(554, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 241);
            this.panel3.TabIndex = 26;
            // 
            // txtSecSil
            // 
            this.txtSecSil.Location = new System.Drawing.Point(17, 21);
            this.txtSecSil.Multiline = true;
            this.txtSecSil.Name = "txtSecSil";
            this.txtSecSil.ReadOnly = true;
            this.txtSecSil.Size = new System.Drawing.Size(178, 135);
            this.txtSecSil.TabIndex = 13;
            this.txtSecSil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSecSil
            // 
            this.btnSecSil.BackColor = System.Drawing.Color.White;
            this.btnSecSil.Location = new System.Drawing.Point(56, 173);
            this.btnSecSil.Name = "btnSecSil";
            this.btnSecSil.Size = new System.Drawing.Size(108, 51);
            this.btnSecSil.TabIndex = 10;
            this.btnSecSil.Text = "Sil";
            this.btnSecSil.UseVisualStyleBackColor = false;
            this.btnSecSil.Click += new System.EventHandler(this.btnSecSil_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(12, 442);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(82, 41);
            this.btnGeri.TabIndex = 25;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseCompatibleTextRendering = true;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.txtSecOnayla);
            this.panel1.Controls.Add(this.btnSecOnayla);
            this.panel1.Location = new System.Drawing.Point(92, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 241);
            this.panel1.TabIndex = 23;
            // 
            // txtSecOnayla
            // 
            this.txtSecOnayla.Location = new System.Drawing.Point(18, 21);
            this.txtSecOnayla.Multiline = true;
            this.txtSecOnayla.Name = "txtSecOnayla";
            this.txtSecOnayla.ReadOnly = true;
            this.txtSecOnayla.Size = new System.Drawing.Size(178, 135);
            this.txtSecOnayla.TabIndex = 13;
            this.txtSecOnayla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSecOnayla
            // 
            this.btnSecOnayla.BackColor = System.Drawing.Color.White;
            this.btnSecOnayla.Location = new System.Drawing.Point(52, 173);
            this.btnSecOnayla.Name = "btnSecOnayla";
            this.btnSecOnayla.Size = new System.Drawing.Size(108, 51);
            this.btnSecOnayla.TabIndex = 10;
            this.btnSecOnayla.Text = "Onayla";
            this.btnSecOnayla.UseCompatibleTextRendering = true;
            this.btnSecOnayla.UseVisualStyleBackColor = false;
            this.btnSecOnayla.Click += new System.EventHandler(this.btnSecOnayla_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(826, 150);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tblYoneticiBindingSource
            // 
            this.tblYoneticiBindingSource.DataMember = "Tbl_Yonetici";
            this.tblYoneticiBindingSource.DataSource = this.tHYDataSetBindingSource;
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
            // tbl_YoneticiTableAdapter
            // 
            this.tbl_YoneticiTableAdapter.ClearBeforeFill = true;
            // 
            // YOnayla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 491);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "YOnayla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YOnayla";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YOnayla_FormClosing);
            this.Load += new System.EventHandler(this.YOnayla_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblYoneticiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHYDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHYDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSecOnayKaldir;
        private System.Windows.Forms.Button btnSecOnayKaldir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSecSil;
        private System.Windows.Forms.Button btnSecSil;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSecOnayla;
        private System.Windows.Forms.Button btnSecOnayla;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tHYDataSetBindingSource;
        private THYDataSet tHYDataSet;
        private System.Windows.Forms.BindingSource tblYoneticiBindingSource;
        private THYDataSetTableAdapters.Tbl_YoneticiTableAdapter tbl_YoneticiTableAdapter;
    }
}