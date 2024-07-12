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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

// Ahmet Zateroğlu 200707025


namespace THY
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JIKNC4U;Initial Catalog=THY;Integrated Security=True");
        int onay = 0; // Kapasite var mı diye bakılacak
        DataTable dt = new DataTable(); // Bu tabloyu sonraki forma atıcam ondan global tanımladım

        private void AnaSayfa_Load(object sender, EventArgs e)
        {            
            dateTimePicker1.Value = DateTime.Now; // Datetimepicker daki tarihi bugun olarak ayarlıyoruz
        }


        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                // up_UcusAr sp sini çağırıyoruz ve girilen verilere uygun uçuş var mı bakıyorz

                SqlCommand komut = new SqlCommand("Exec up_UcusAra @s1,@s2,@s3", baglanti);
                komut.Parameters.AddWithValue("@s1", cmbNerden.Text.Trim());
                komut.Parameters.AddWithValue("@s2", cmbNereye.Text.Trim());
                komut.Parameters.AddWithValue("@s3", dateTimePicker1.Text.Trim());
               
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);  // Uygun uçuş varsa tabloya kaydediyoruz

                SqlDataReader oku = komut.ExecuteReader();  // Komutu okuyoruz
                while (oku.Read()) // Okuduğu sürece
                {
                    if(radioButton1.Checked==true)  // Tip olarak bussines seçilmişse bussines kapasitesine                                          
                    {                               // bakıyoruz yer varsa onay alıyor
                        if (int.Parse(oku["BusinessKapasite"].ToString()) >= int.Parse(txtYolcuSayisi.Text))
                        {
                            onay = 1;

                        }
                        else  // Yer yoksa onay alamıyor
                        {
                            onay = 0;
                        }
                          
                    }
                    else if(radioButton2.Checked==true)  // Eğer economy tipi seçilmişse bu sefer ekonomi tipi için bakılıyor
                    {
                        // Veri tabanındaki sayı Bizim girdiğimiz sayıdan büyükse onay alıyor
                        if (int.Parse(oku["EconomyKapasite"].ToString()) >= int.Parse(txtYolcuSayisi.Text)) 
                        {
                            onay = 1;

                        }
                        else
                            onay = 0;

                    }
                    

                }
                if (dt.Rows.Count > 0  && onay == 1)  // Eğer dt tablosunda uygun veriler varsa ve 
                {                                     // kapasite onayı verilmişse uçuş vardır
                    MessageBox.Show("Uçuş Var");           
                    UcusAra form = new UcusAra();  // Uçuş Ara Formu açılır
                    form.dataGridView1.DataSource = dt; // Uçuş Ara Formundaki datagride bizim dtdeki verileri aktarırız
                    form.lblKId.Text = lblKId.Text; // Bu formdaki id ( ki bu id viisble ve kullanıcı girişi yerinde giriş yapılırsa atanıyor) diğer forma aktarılır
                    form.txtKAd.Text = txtKAd.Text;  // Bu formdaki kullanıcı adı diğer forma aktarılır böylece mesela Hoşgeldin Ahmet diyebiliyoru
                    form.textBox2.Text = txtYolcuSayisi.Text; // Bu formdaki yolcu sayısı diğer forma aktarılır
                    
                    if (radioButton1.Checked == true)  // Bu formdaki uçuş tipi radiobutona göre diğer forma aktarılır
                        form.textBox3.Text = "Business";
                    else if (radioButton2.Checked == true)
                        form.textBox3.Text = "Economy";
                    form.Show();
                    this.Hide();
                }
                else  // Eğer şartlar sağlanmamışsa uygun uçuş yok demektir
                {
                    MessageBox.Show("Uçuş Yok");
                }
                baglanti.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Hata Tekrar Deneyiniz");
            }

        }





        private void btnGirisEkrani_Click(object sender, EventArgs e)
        {           
            GirisEkrani form = new GirisEkrani(); // Bizi Giriş ekranına Götürür
            form.Show();
            this.Hide();           
        }
        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Formu kapattığında komple uygulama kapansın bunu yapmazsak
            // Arka planda diğer formlar hide da çalışıyor

            Application.Exit();
        }

        private void btnBilet_Click(object sender, EventArgs e)
        {
            Bilet form = new Bilet(); // Bizi Bilet formuna götürür
            form.ShowDialog();  // Bunlarda thisçHide veya show demiyoruz ek olarak açılıp çarpı dendiğinde alttaki
            // Sayfaya gidilsin istiyorum
           
        }

        private void btnUcusDurumu_Click(object sender, EventArgs e)
        {
            UcusDurumu form = new UcusDurumu(); // Bizi UcusDurumu formuna götürür
            form.ShowDialog();
          
        }

       
    }
}
