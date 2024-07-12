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
    public partial class Bilet : Form
    {
        public Bilet()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JIKNC4U;Initial Catalog=THY;Integrated Security=True");

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
           
            baglanti.Open();

             // View Kullanarak istenilen bilet bilgisini istenilen koşullara göre Çekiyoruz
             SqlCommand komut = new SqlCommand("select * from BiletGöster  where [Bilet Kodu]=@s1 and Soyad=@s2 ", baglanti); // İlerde ne göstereeceği değişebilir
            try
            {
                // Parametreleri alıyoruz
                komut.Parameters.AddWithValue("@s1", int.Parse(textBox1.Text.Trim()));
                komut.Parameters.AddWithValue("@s2", textBox2.Text.Trim());

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt); // Tabloya kaydediyoruz

                if(dt.Rows.Count == 0 )  // Eğer tablo boşssa öyle bir bilet yok demek
                {
                    MessageBox.Show("Böyle Bir Bilet Yok");
                    dataGridView1.Columns.Clear();
                }
                else  // Eğer 0 değilse var demektir o zamanda tabloyu datagride ekliyoruz
                {
                    dataGridView1.DataSource = dt;
                }

            }
            catch
            {
                MessageBox.Show("Hata");
            }

            baglanti.Close();



        }
      
    }
}
