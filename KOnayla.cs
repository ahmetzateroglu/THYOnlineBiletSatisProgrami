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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

// Ahmet Zateroğlu 200707025

namespace THY
{
    public partial class KOnayla : Form
    {
        public KOnayla()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JIKNC4U;Initial Catalog=THY;Integrated Security=True");
        int secilen; // Datagridde seçilen rowu tutmamızı sağlayacak
        string kKod; // Datagridde seçilen rowdaki kullanıcı id tutmamızı sağlayacak

        private void KOnayla_Load(object sender, EventArgs e)
        {
            Listele();  // Sp sayesinde listeliyoruz           
        }

        private void Listele()  // Sadece ilk yüklenmede kullanıyoruz
        {
            try
            {
                baglanti.Open();
                // Sp sayesinde listeliyoruz
                SqlCommand komut = new SqlCommand("Exec up_KullaniciListele", baglanti);

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

            // Sp sayesinde update yapıyoruz
            SqlCommand komut = new SqlCommand("Exec up_KullaniciSecOnayla @g2,@g1", baglanti);
            try
            {
                komut.Parameters.AddWithValue("@g1", int.Parse(kKod));
                komut.Parameters.AddWithValue("@g2", "Onaylı");                
                komut.ExecuteNonQuery();          
                MessageBox.Show("Kullanıcı Onaylandı");

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

            // Sp sayesinde update yapıyoruz
            SqlCommand komut = new SqlCommand("Exec up_KullaniciSecOnayKaldir @g2,@g1", baglanti);
            try
            {
                komut.Parameters.AddWithValue("@g1", int.Parse(kKod));
                komut.Parameters.AddWithValue("@g2", "Onaysız");
                komut.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı Onay Kaldırıldı");

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
            // Sp sayesinde delete yapıyoruz

            SqlCommand komut = new SqlCommand("Exec up_KullaniciSecSil @s1", baglanti);
            komut.Parameters.AddWithValue("s1", dataGridView1.Rows[secilen].Cells[0].Value.ToString());
            komut.ExecuteNonQuery();

            MessageBox.Show("Kullanıcı Silindi");

            // Trigger sayesinde silme olduktan sonra listeleme olucak
            // Biz bunu kullanarak silmeden sonra yeni halini listeliyoruz

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
                    secilen = dataGridView1.SelectedCells[0].RowIndex; // Seçilen rowun indisini alıyoruz
                    kKod = dataGridView1.Rows[secilen].Cells[0].Value.ToString().Trim(); // Seçilen rowdaki id yi alıyoruz
                    // İd ile ilgili yapılacak işlemlerin bilgisini yazdırıyoruz
                    txtSecOnayla.Text= dataGridView1.Rows[secilen].Cells[0].Value.ToString().Trim() + " ID'li Kullanıcının Hesabı Onaylanacak";
                    txtSecOnayKaldir.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString().Trim() + " ID'li Kullanıcının Onayı Kalkacak";
                    txtSecSil.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString().Trim() + " ID'li Kullanıcının Hesabı Silinecek";
                }
                catch (Exception)
                {

                    MessageBox.Show("Seçilecek Bir Şey Yok");
                }



            
        }

        private void KOnayla_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Formu kapattığında komple uygulama kapansın bunu yapmazsak
            // Arka planda diğer formlar hide da çalışıyor

            Application.Exit();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            // Eğer Giriş Yapan Adminse Admin Formuna Değilse Yonetici Formuna Gidecek.
            // Bunun labellerla formlar arası giren kişi bilgisini taşıyarak biliyoruz

            if(label1.Text=="Admin")
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

       
    }
}
