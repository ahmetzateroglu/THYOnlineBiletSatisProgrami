using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace THY
{
    public partial class UcusEkle : Form
    {
        public UcusEkle()
        {
            InitializeComponent();
        }
        // Datetme ticker da propertiesden formatı custom format yaptım ve ona göre  ayarladım
        
        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JIKNC4U;Initial Catalog=THY;Integrated Security=True");
        int secilen;

        private void UcusEkle_Load(object sender, EventArgs e)
        {

            Listele();
            Temizle();

        }

        private void Listele()
        {
            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("select * from Tbl_Ucus", baglanti);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Tekrar Deneyiniz");
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("Insert into Tbl_Ucus (UcusKodu,Nerden,Nereye,Tarih,Kalkis,Varis, BusinessKapasite, BusinessFiyat, EconomyKapasite, EconomyFiyat) values (@k1,@k2,@k3,@k4,@k5,@k6,@k7,@k8,@k9,@k10)", baglanti);

                komut.Parameters.AddWithValue("@k1", txtKod.Text.Trim());
                komut.Parameters.AddWithValue("@k2", cmbNerden.Text.Trim());
                komut.Parameters.AddWithValue("@k3", cmbNereye.Text.Trim());
                komut.Parameters.AddWithValue("@k4", dateTimePicker1.Text.Trim());
                komut.Parameters.AddWithValue("@k5", dateTimePicker2.Text.Trim());
                komut.Parameters.AddWithValue("@k6", dateTimePicker3.Text.Trim());
                komut.Parameters.AddWithValue("@k7", int.Parse(txtBK.Text.Trim()));
                komut.Parameters.AddWithValue("@k8", int.Parse(txtBF.Text.Trim()));
                komut.Parameters.AddWithValue("@k9", int.Parse(txtEK.Text.Trim()));
                komut.Parameters.AddWithValue("@k10", int.Parse(txtEF.Text.Trim()));
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Başarılı");
                Temizle();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }
            
        }



       
        private void Temizle()
        {
            txtKod.Text = "TR";
            cmbNerden.Text = "";
            cmbNereye.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;
            txtBK.Text = "";
            txtBF.Text = "";
            txtEK.Text = "";
            txtBF.Text = "";

            txtGKod.Text = "";
            cmbGNerden.Text = "";
            cmbGNereye.Text = "";
            dateTimePicker4.Value = DateTime.Now;
            dateTimePicker5.Value = DateTime.Now;
            dateTimePicker6.Value = DateTime.Now;
            txtGBK.Text = "";
            txtGBF.Text = "";
            txtGEK.Text = "";
            txtGBF.Text = "";

            txtSecSil.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                secilen = dataGridView1.SelectedCells[0].RowIndex; // Kodu alıcak
                txtSecSil.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString().Trim() + " Kodlu Uçuş Seçildi.";

                txtGKod.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString().Trim();
                cmbGNerden.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString().Trim();
                cmbGNereye.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString().Trim();
                dateTimePicker4.Value = DateTime.Parse(dataGridView1.Rows[secilen].Cells[3].Value.ToString().Trim());
                dateTimePicker5.Value = DateTime.Parse(dataGridView1.Rows[secilen].Cells[4].Value.ToString().Trim());
                dateTimePicker6.Value = DateTime.Parse(dataGridView1.Rows[secilen].Cells[5].Value.ToString().Trim());
                txtGBK.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString().Trim();
                txtGBF.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString().Trim();
                txtGEK.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString().Trim();
                txtGEF.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString().Trim();
            }
            catch (Exception)
            {

                MessageBox.Show("Seçilecek Bir Şey Yok");
            }
            
           
            
        }

        private void btnSecSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("delete from Tbl_Ucus where UcusKodu=@s1", baglanti);
            komut.Parameters.AddWithValue("s1", dataGridView1.Rows[secilen].Cells[0].Value.ToString());
            komut.ExecuteNonQuery();

     
            
            baglanti.Close();
            Listele();
            Temizle();
            MessageBox.Show("Kayit silini");
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            // Colum name tablo adi dikkat et sqlden bak al
            SqlCommand komut = new SqlCommand(" update Tbl_Ucus Set Nerden=@g2,Nereye=@g3,Tarih=@g4,Kalkis=@g5,Varis=@g6,BusinessKapasite=@g7,BusinessFiyat=@g8,EconomyKapasite=@g9,EconomyFiyat=@g10 where UcusKodu=@g1", baglanti);

            try
            {
                komut.Parameters.AddWithValue("@g1", txtGKod.Text.Trim());
                komut.Parameters.AddWithValue("@g2", cmbGNerden.Text.Trim());
                komut.Parameters.AddWithValue("@g3", cmbGNereye.Text.Trim());
                komut.Parameters.AddWithValue("@g4", dateTimePicker4.Text.Trim());
                komut.Parameters.AddWithValue("@g5", dateTimePicker5.Text.Trim());
                komut.Parameters.AddWithValue("@g6", dateTimePicker6.Text.Trim());
                komut.Parameters.AddWithValue("@g7", int.Parse(txtGBK.Text.Trim()));
                komut.Parameters.AddWithValue("@g8", int.Parse(txtGBF.Text.Trim()));
                komut.Parameters.AddWithValue("@g9", int.Parse(txtGEK.Text.Trim()));
                komut.Parameters.AddWithValue("@g10", int.Parse(txtGEF.Text.Trim()));
                komut.ExecuteNonQuery();


                Temizle();
                MessageBox.Show("Güncelleme Başarılı");

            }
            catch
            {
                MessageBox.Show("Hata");
            }

            baglanti.Close();
            Listele();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            // Eğer Giriş Yapan Adminse Admin Formuna Değilse Yonetici Formuna Gidecek.

            if (label9.Text == "Admin")
            {
                Admin form = new Admin();
                form.Show();
                this.Hide();
            }
            else
            {
                Yonetici form = new Yonetici();
                form.Show();
                this.Hide();
            }



        }

        private void UcusEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Formu kapattığında komple uygulama kapansın bunu yapmazsak
            // Arka planda diğer formlar hide da çalışıyor

            Application.Exit();
        }
    }
}
