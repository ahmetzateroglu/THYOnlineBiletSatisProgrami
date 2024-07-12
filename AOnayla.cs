using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Ahmet Zateroğlu 200707025

namespace THY
{
    public partial class AOnayla : Form
    {
        public AOnayla()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JIKNC4U;Initial Catalog=THY;Integrated Security=True");
        int secilen;
        string kKod;

        private void AOnayla_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            try
            {
                baglanti.Open();
                // Burda sp kullanarak admini adminleri datagride listeliyorum
                SqlCommand komut = new SqlCommand("Exec up_AdminListele", baglanti);
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

        private void btnSecOnayla_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            // Sp ile seçilen admin Onaylanıyor Hangisinin Seçildiğini seçilen adminin kodunu kKoda atayarak biliyoruz
            SqlCommand komut = new SqlCommand("Exec up_AdminSecOnayla @g2,@g1", baglanti);
            try
            {
                komut.Parameters.AddWithValue("@g1", int.Parse(kKod));
                komut.Parameters.AddWithValue("@g2", "Onaylı");
                komut.ExecuteNonQuery();
                MessageBox.Show("Admin Onaylandı");
                //
                // Trigger sayesinde güncelleme olduktan sonra listeleme olucak
                // Biz bunu kullanarak güncellemeden sonra yeni halini listeliyoruz
                //
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch
            {
                MessageBox.Show("Hata");
            }
            baglanti.Close();

            Temizle();
        }

        private void btnSecOnayKaldir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            // Sp ile seçilen admin Onay Kalkıyor Hangisinin Seçildiğini seçilen adminin kodunu kKoda atayarak biliyoruz
            SqlCommand komut = new SqlCommand("Exec up_AdminSecOnayKaldir @g2,@g1", baglanti);
            try
            {
                komut.Parameters.AddWithValue("@g1", int.Parse(kKod));
                komut.Parameters.AddWithValue("@g2", "Onaysız");
                komut.ExecuteNonQuery();
                MessageBox.Show("Admin Onay Kaldırıldı");

                // Trigger sayesinde güncelleme olduktan sonra listeleme olucak
                // Biz bunu kullanarak güncellemeden sonra yeni halini listeliyoruz

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch
            {
                MessageBox.Show("Hata");
            }
            baglanti.Close();

            Temizle();

        }
        private void btnSecSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            // Sp il Seçilen admini siliyoruz
            SqlCommand komut = new SqlCommand("Exec up_AdminSecSil @s1", baglanti);
            komut.Parameters.AddWithValue("s1", dataGridView1.Rows[secilen].Cells[0].Value.ToString());
            komut.ExecuteNonQuery();

            MessageBox.Show("Admin Silindi");

            // Trigger sayesinde silme olduktan sonra listeleme olucak
            // Biz bunu kullanarak güncellemeden sonra yeni halini listeliyoruz

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            baglanti.Close();

            Temizle();


        }
       
        private void Temizle()
        {
            txtSecOnayla.Text = "";
            txtSecOnayKaldir.Text = "";
            txtSecSil.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                secilen = dataGridView1.SelectedCells[0].RowIndex; // Kodun rowu alınacak
                kKod = dataGridView1.Rows[secilen].Cells[0].Value.ToString().Trim(); // Seçilenin kodu kKoda atanacak
                // Hangisi seçilmiş uyarıları veriliyor
                txtSecOnayla.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString().Trim() + " ID'li Adminin Hesabı Onaylanacak";
                txtSecOnayKaldir.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString().Trim() + " ID'li Adminin Onayı Kalkacak";
                txtSecSil.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString().Trim() + " ID'li Adminin Hesabı Silinecek";
            }
            catch (Exception)
            {

                MessageBox.Show("Seçilecek Bir Şey Yok");
            }
        }

        private void AOnayla_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Formu kapattığında komple uygulama kapansın bunu yapmazsak
            // Arka planda diğer formlar hide da çalışıyor

            Application.Exit();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
           // AOnayla yöneticiye özel form o yüzden direk geri dönüşte yönetici sayfasına gider

            Yonetici form = new Yonetici();
            form.Show();
            this.Hide();
        }
    }
}
