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
    public partial class YOnayla : Form
    {
        public YOnayla()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JIKNC4U;Initial Catalog=THY;Integrated Security=True");
        int secilen;
        string kKod;

        private void YOnayla_Load(object sender, EventArgs e)
        {
            //  this.tbl_YoneticiTableAdapter.Fill(this.tHYDataSet.Tbl_Yonetici);
            Listele();

        }

        private void Listele()
        {
            try
            {
                baglanti.Open();
                // Sp ile listeleme yapıyorz
                SqlCommand komut = new SqlCommand("Exec up_YoneticiListele", baglanti);

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
            // sp ile seçilen yönetici onaylıyoruz
            SqlCommand komut = new SqlCommand("Exec up_YoneticiSecOnayla @g2,@g1", baglanti);
            try
            {
                komut.Parameters.AddWithValue("@g1", int.Parse(kKod));
                komut.Parameters.AddWithValue("@g2", "Onaylı");
                komut.ExecuteNonQuery();

                MessageBox.Show("Yonetici Onaylandı");

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

        private void btnSecOnayKaldir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            // sp ile seçilen yönetici onay kaldırıyoruz
            SqlCommand komut = new SqlCommand("Exec up_YoneticiSecOnayKaldir @g2,@g1", baglanti);
            try
            {
                komut.Parameters.AddWithValue("@g1", int.Parse(kKod));
                komut.Parameters.AddWithValue("@g2", "Onaysız");
                komut.ExecuteNonQuery();

                MessageBox.Show("Yonetici Onay Kaldırıldı");

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
            // sp ile seçilen yöntici siliyoruz
            SqlCommand komut = new SqlCommand("Exec up_YoneticiSecSil @s1", baglanti);
            komut.Parameters.AddWithValue("s1", dataGridView1.Rows[secilen].Cells[0].Value.ToString());
            komut.ExecuteNonQuery();

            MessageBox.Show("Yonetici Silindi");

            // Trigger sayesinde silme olduktan sonra listeleme olucak
            // Biz bunu kullanarak silmeden sonra yeni halini listeliyoruz
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            baglanti.Close();

            Temizle();
        }       

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                secilen = dataGridView1.SelectedCells[0].RowIndex; // Kodun rowu alınacak
                kKod = dataGridView1.Rows[secilen].Cells[0].Value.ToString().Trim();// Seçilenin kodu kKoda atanacak
                // Hangisi seçilmiş uyarıları veriliyor
                txtSecOnayla.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString().Trim() + " ID'li Yöneticinin Hesabı Onaylanacak";
                txtSecOnayKaldir.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString().Trim() + " ID'li Yöneticinin Onayı Kalkacak";
                txtSecSil.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString().Trim() + " ID'li Yöneticinin Hesabı Silinecek";
            }
            catch (Exception)
            {

                MessageBox.Show("Seçilecek Bir Şey Yok");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            // Yönetici özel form eğer adminede yaparsan giriş ekran çıksın ya da gireni bilsin

            Yonetici form = new Yonetici();
            form.Show();
            this.Hide();
        }

        
        private void Temizle()
        {
            txtSecOnayla.Text = "";
            txtSecOnayKaldir.Text = "";
            txtSecSil.Text = "";
        }


        private void YOnayla_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Formu kapattığında komple uygulama kapansın bunu yapmazsak
            // Arka planda diğer formlar hide da çalışıyor

            Application.Exit();
        }
    }
}
