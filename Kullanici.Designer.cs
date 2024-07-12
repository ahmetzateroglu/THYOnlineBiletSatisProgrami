namespace THY
{
    partial class Kullanici
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
            this.btngeri = new System.Windows.Forms.Button();
            this.lblKId = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKAd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btngeri
            // 
            this.btngeri.Location = new System.Drawing.Point(12, 437);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(105, 43);
            this.btngeri.TabIndex = 3;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // lblKId
            // 
            this.lblKId.AutoSize = true;
            this.lblKId.Location = new System.Drawing.Point(394, 33);
            this.lblKId.Name = "lblKId";
            this.lblKId.Size = new System.Drawing.Size(54, 20);
            this.lblKId.TabIndex = 4;
            this.lblKId.Text = "lblKId";
            this.lblKId.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bilet Alımlarınız";
            // 
            // txtKAd
            // 
            this.txtKAd.BackColor = System.Drawing.Color.White;
            this.txtKAd.Location = new System.Drawing.Point(295, 61);
            this.txtKAd.Margin = new System.Windows.Forms.Padding(8);
            this.txtKAd.Name = "txtKAd";
            this.txtKAd.ReadOnly = true;
            this.txtKAd.Size = new System.Drawing.Size(245, 26);
            this.txtKAd.TabIndex = 19;
            this.txtKAd.Text = "Hoşgeldin";
            this.txtKAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 491);
            this.Controls.Add(this.txtKAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblKId);
            this.Controls.Add(this.btngeri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Kullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanici";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kullanici_FormClosing);
            this.Load += new System.EventHandler(this.Kullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngeri;
        public System.Windows.Forms.Label lblKId;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtKAd;
    }
}