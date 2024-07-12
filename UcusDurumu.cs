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
    public partial class UcusDurumu : Form
    {
        public UcusDurumu()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JIKNC4U;Initial Catalog=THY;Integrated Security=True");

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {

            baglanti.Open();

            // Bizi İstenilen şarta göre (uçuş kodu) Uçuş gösterecek sorguyu yazoyoruz
            SqlCommand komut = new SqlCommand("select * from Tbl_Ucus where UcusKodu=@s1 ", baglanti);
            try
            { 
                // Parametreyi giriyoruz
                komut.Parameters.AddWithValue("@s1", textBox1.Text.Trim());

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt); // O parametreye uygun tabloyu çekiyoruz ve datagride ekliyoruz
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Hata");
            }

            baglanti.Close();
        }

    }
}
