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

// Ahmet Zateroğlu 200707025
namespace THY
{
    public partial class Kullanici : Form
    {
        public Kullanici()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JIKNC4U;Initial Catalog=THY;Integrated Security=True");


        private void Kullanici_Load(object sender, EventArgs e)
        {

            Listele();

        }


        private void Listele()
        {
            try
            {
                baglanti.Open();
                // viewi burda da kullanarak ve uygun şartları söylyerek bilet bilgilerini gösteriyoruz
                SqlCommand komut = new SqlCommand("select * from BiletGöster where [Kullanıcı Id] = @s1 order by [Alım Tarihi] Desc", baglanti);
                // Parametre atıyoruz
                komut.Parameters.AddWithValue("@s1", (lblKId.Text));

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                dataGridView1.DataSource = dt; // Uygun olan verileri datagride atıyoruz

                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Tekrar Deneyiniz");
            }
        }

        private void Kullanici_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            AnaSayfa form = new AnaSayfa(); // Çıkış yaptığımızda giriş yapan kullanıcı ad ve idsini ana sayfaya taşıyoruz
            // Böylece ordan diğer sayfalara taşınabilecek ve satın alma kısmında ekstra girişe gerek kalmayacak
            form.lblKId.Text = lblKId.Text;
            form.txtKAd.Text = txtKAd.Text;

            form.Show();
            this.Hide();
        }
    }
}
