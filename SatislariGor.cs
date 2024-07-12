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
    public partial class SatislariGor : Form
    {
        public SatislariGor()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JIKNC4U;Initial Catalog=THY;Integrated Security=True");
        int secilen;
        private void SatislariGor_Load(object sender, EventArgs e)
        {
            Listele();
        }


        private void btnYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("delete from Tbl_Alimlar where BiletKodu=@s1", baglanti);
            komut.Parameters.AddWithValue("s1", dataGridView1.Rows[secilen].Cells[4].Value.ToString());
            komut.ExecuteNonQuery();       
            baglanti.Close();

            Listele();

            MessageBox.Show("Kayit silini");
        }

        private void Listele()
        {
            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("select * from Tbl_Alimlar order by BiletKodu Desc", baglanti);
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

        private void btngeri_Click(object sender, EventArgs e)
        {
            // Eğer Giriş Yapan Adminse Admin Formuna Değilse Yonetici Formuna Gidecek.

            if (label1.Text == "Admin")
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

        private void SatislariGor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtSecSil.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString().Trim() + " Id'li Kullanıcının Bilet Satışı Silinecek";
        }

        
    }
}
