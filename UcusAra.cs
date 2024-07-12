using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Ahmet Zateroğlu 200707025

namespace THY
{
    public partial class UcusAra : Form
    {
        public UcusAra()
        {
            InitializeComponent();
        }


        int secilen; // Datagridde seçilen rowu tutuyor
        string kKod; // Alınan kodu kaydediyor ve textboxda gçsteriyouz

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa form = new AnaSayfa();
            form.lblKId.Text = lblKId.Text;
            form.txtKAd.Text += txtKAd.Text;
            form.Show();
            this.Hide();
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                secilen = dataGridView1.SelectedCells[0].RowIndex; // Rowu tutuyor
                kKod = dataGridView1.Rows[secilen].Cells[0].Value.ToString().Trim(); // seçilen rowdaki kodu alyoruz
                textBox1.Text = kKod + " kodlu uçuş seçildi."; // Textboxa not ediyoruz
            }
            catch (Exception)
            {

                MessageBox.Show("Seçilecek Bir Şey Yok");
            }

        }

        private void UcusAra_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Formu kapattığında komple uygulama kapansın bunu yapmazsak
            // Arka planda diğer formlar hide da çalışıyor

            Application.Exit();
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {

            if(textBox1.Text == "") // Boşsa uçuş seçilmemiş demek
            {
                MessageBox.Show("Uçuş Seçilmedi");
            }
            else
            {
                SatinAl form = new SatinAl(); // Uçuş seçilmişse Satın al formunu açıyoruz
                form.lblKId.Text = lblKId.Text; // Ana sayfa forundan aldığımız kodları yine bundan sonraki sayfaya taşıyoruz
                form.txtKAd.Text += txtKAd.Text;
                form.txtYolcuSayisi.Text = textBox2.Text;
                form.txtBiletTipi.Text = textBox3.Text;

                form.txtUcusKodu.Text = kKod; // Buradanda ekstra olarak seçtiğimiz seferin kodunu sonraki sayfaya taşıyoruz
                form.Show();
                this.Hide();
            }
        
        }

      

    }
}
