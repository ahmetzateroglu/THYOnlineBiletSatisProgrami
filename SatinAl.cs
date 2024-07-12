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
    public partial class SatinAl : Form
    {
        public SatinAl()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JIKNC4U;Initial Catalog=THY;Integrated Security=True");
        string id;
        int onay = 0;


        private void SatinAl_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;  // İlk Girdiğimizde Giriş Ve Ödeme Paneli Kapatılıyor
            panel3.Visible = false;

            if (lblKId.Text == "")  // Eğer önceden giriş yapılmamışsa lblKId boş oluyor ve bir şey yapılmıyor
            {
            }
            else // lblKId Boş değilse önceden giriş yapılmış demektir bu durumda idye göre bazı
            {    //  bilgileri kullanıcı için otomatik giriyoruz
                baglanti.Open();

                // Sorgu yazılıyor ve okunuyor sonra bu bilgileri bizim formdaki yerleri doldurmak için kullanıyoruz.
                SqlCommand komut = new SqlCommand("select Ad,Soyad,KimlikNo,Telefon from Tbl_Kullanici where KullaniciId=@s1", baglanti);
                komut.Parameters.AddWithValue("@s1", int.Parse(lblKId.Text.Trim()));
                komut.ExecuteNonQuery();

                SqlDataReader oku = komut.ExecuteReader();
                oku.Read();
                
                txtAd.Text = oku["Ad"].ToString().Trim();
                txtSoyad.Text = oku["Soyad"].ToString().Trim();
                maskedTextBox1.Text = oku["KimlikNo"].ToString().Trim();
                maskedTextBox2.Text = oku["Telefon"].ToString().Trim();

                baglanti.Close();


            }
        }


        private void btnOnayla_Click(object sender, EventArgs e)
        {
            // Bilgiler Eksiksizse ödeme kısmı açılır ödeme kısmı formalite bir kısım ordan da bilgiler girilip satın alma işlemi tamamlanır.

            if (maskedTextBox1.Text.Length < 11 || maskedTextBox2.Text.Length < 11 || txtAd.Text.Length < 1 || txtSoyad.Text.Length < 1)
            {
                MessageBox.Show("Bilgiler Eksik");

            }
            else
            {
                panel3.Visible = true; // Ödeme Paneli açılır
            }
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
          
            // Ödeme Bilgilerine bak boş yoksa işlemi tamamla

            if (textBox1.Text.Length < 1 || textBox2.Text.Length < 1) 
            {
                MessageBox.Show("Bilgiler Eksik");
                
            }
            else
            {
                if (lblKId.Text != string.Empty)  // Giriş Var mı yok mu burdan anlıyoruz. Yine Giriş yoksa anonim bir alım oluyor onda da id olarak TC yi alıyoruz
                {
                  //  MessageBox.Show("Kullanıcı Alımı");  // Giriş Yapılmış Kayıtlı Bir Üyenini Alımı
                   try
                   {
                        baglanti.Open();
                        // Sp sayesinde Alım veri tabanına yeni Alım ekliyoruz
                        SqlCommand komut = new SqlCommand("Exec up_AlimEkle @k1,@k2,@k3,@k4,@k5,@k6,@k7", baglanti); 

                        komut.Parameters.AddWithValue("@k1", lblKId.Text.Trim()); // Giriş Olduğu içn Alımı kullanıcının idsi ile yapıyoruz
                        komut.Parameters.AddWithValue("@k2", txtAd.Text.Trim());
                        komut.Parameters.AddWithValue("@k3", txtSoyad.Text.Trim());
                        komut.Parameters.AddWithValue("@k4", txtUcusKodu.Text.Trim()); 
                        komut.Parameters.AddWithValue("@k5", int.Parse(txtYolcuSayisi.Text));
                        komut.Parameters.AddWithValue("@k6", txtBiletTipi.Text.Trim());
                        komut.Parameters.AddWithValue("@k7", DateTime.Today);
                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        MessageBox.Show("Başarılı");

                    }
                    catch (Exception)
                    {
                       MessageBox.Show("Hata");
                    }

                }
                else
                {
                    // MessageBox.Show("Anonim Alım");  // Eğer Giriş Yapılmamışsa anonim alımdır kullanıcının Tcsi ile kayıt alıyoruz

                   try
                   {
                        baglanti.Open();

                        SqlCommand komut = new SqlCommand("Exec up_AlimEkle @k1,@k2,@k3,@k4,@k5,@k6,@k7", baglanti);

                        komut.Parameters.AddWithValue("@k1", maskedTextBox1.Text.Trim());  // Alım kullanıcı idsiyle değilde Tc siyle oluyor
                        komut.Parameters.AddWithValue("@k2", txtAd.Text.Trim());
                        komut.Parameters.AddWithValue("@k3", txtSoyad.Text.Trim());
                        komut.Parameters.AddWithValue("@k4", txtUcusKodu.Text.Trim());  // Uçuş Kodu
                        komut.Parameters.AddWithValue("@k5", int.Parse(txtYolcuSayisi.Text));
                        komut.Parameters.AddWithValue("@k6", txtBiletTipi.Text.Trim());
                        komut.Parameters.AddWithValue("@k7", DateTime.Today);
                        komut.ExecuteNonQuery();

                        baglanti.Close();

                        MessageBox.Show("Başarılı");

                   }
                   catch (Exception)
                   {
                        MessageBox.Show("Hata");
                   }
                }

                baglanti.Open();

                // Alım olduktan sonra kullanıcının daha sonra bileti kontrol etmesi için biet kodunu ona kod veriyoruz
                // Bilet kodu kendi kendine birer birer artığı için tabloyu büyükten küçüğe sıralıyor ve
                // en üstteki yani en büyük bilet kodunu
                // alıyoruz ve kullanıcıya iletiyoruz ardından ana sayfaya dönülüyor
                SqlCommand komut1 = new SqlCommand("select top 1 BiletKodu from Tbl_Alimlar order by BiletKodu Desc", baglanti);
                SqlDataReader oku = komut1.ExecuteReader();
                oku.Read();
                MessageBox.Show("Bilet Kodunuzu Not Ediniz: " + oku["BiletKodu"].ToString());
                baglanti.Close();

                // Ana Sayfaya Dönüş
                AnaSayfa form = new AnaSayfa();
                form.lblKId.Text = lblKId.Text;
                form.txtKAd.Text = txtKAd.Text;
                form.Show();
                this.Hide();


            }

           

        }
       
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;

        }

        

        private void btnGiris_Click(object sender, EventArgs e)
        {
         
            // Eğer kullanıcı Anonim değilde kayıtlı kullanıcıysa buradan  giriş yapabilir bu button panel 2 de
           
            try
            {
                baglanti.Open();

                // Kullanıcı adı şifre ve onaya bakılıyor herşey tamamasa giriş yapılıyor
                SqlCommand komut = new SqlCommand("Select * from Tbl_Kullanici where KullaniciAdi=@adi And KullaniciSifre=@sifresi", baglanti);

                komut.Parameters.AddWithValue("@adi", txtKAdi.Text.Trim());
                komut.Parameters.AddWithValue("@sifresi", txtSifre.Text.Trim());            

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                SqlDataReader oku = komut.ExecuteReader(); // Bunu alta yazdım böylece sistemde 
                // Kayıtlı olanları okuyacak sistemde kayıtlı olanların onaya bakıcak
               
                while (oku.Read()) /// Okuduğu sürece
                {
                    if (oku["Durum"].ToString().Trim() == "Onaylı") 
                    {
                        onay = 1;
                        id = oku["KullaniciId"].ToString().Trim();
                        txtAd.Text= oku["Ad"].ToString().Trim();
                        txtSoyad.Text = oku["Soyad"].ToString().Trim();
                        maskedTextBox1.Text = oku["KimlikNo"].ToString().Trim();
                        maskedTextBox2.Text = oku["Telefon"].ToString().Trim();
                    }
                    else
                        onay = 0;
                }

                if (dt.Rows.Count > 0 && onay == 1)
                {
                    MessageBox.Show("Kullanıcı Girişi Başarılı");
                    txtKAd.Text = "Hoş Geldin "+ txtAd.Text;  // isim id vesayre not ediliyor Alımda buralar kullanılacak
                    lblKId.Text = id.ToString().Trim();
                    panel2.Visible = false;
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş veya Onaysız Hesap");
                }
                baglanti.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa form = new AnaSayfa();
            form.lblKId.Text = lblKId.Text;
            form.txtKAd.Text = txtKAd.Text;
 
            form.Show();
            this.Hide();
        }

        private void SatinAl_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        
    }
}
