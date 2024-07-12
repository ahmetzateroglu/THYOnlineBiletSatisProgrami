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
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JIKNC4U;Initial Catalog=THY;Integrated Security=True");
        int onay = 0;

        string id;  // Giriş yapılan id ve adı çekicem
        string ad;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();               
                string komutYazisi="Select * from Tbl_Kullanici where KullaniciAdi=@adi And KullaniciSifre=@sifresi";
                // Seçilen radiobutona göre sql sorgusu seçilecek
                if (radioButton1.Checked == true)
                {
                    komutYazisi = "Select * from Tbl_Kullanici where KullaniciAdi=@adi And KullaniciSifre=@sifresi";
                }
                else if(radioButton2.Checked == true)
                {
                    komutYazisi = "Select * from Tbl_Admin where AdminKullaniciAdi=@adi And AdminSifre=@sifresi";
                }
                else if(radioButton3.Checked == true)
                {
                    komutYazisi = "Select * from Tbl_Yonetici where YoneticiAdi=@adi And YoneticiSifre=@sifresi";
                }


                SqlCommand komut = new SqlCommand(komutYazisi, baglanti);
                // Ad ve şifreyi alıyoruz
                komut.Parameters.AddWithValue("@adi", txtAd.Text.Trim());
                komut.Parameters.AddWithValue("@sifresi", txtSifre.Text.Trim());

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt); // Uygun olanlar tabloya çekiliyor


                SqlDataReader oku = komut.ExecuteReader(); // Kayıtlı alıcıların onay durumunu okuyacaz
                while (oku.Read())                         //  onaylıysa onay 1 değilse 0 olcak
                {
                    if (oku["Durum"].ToString().Trim() == "Onaylı") 
                    {
                        onay = 1;
                        if (radioButton1.Checked == true)
                        {
                            id=oku["KullaniciId"].ToString().Trim() ; // Onaylıysa giriş olacağından id ve ad alıyorum bunu sonraki formlara atıcam orada kullanıcam
                            ad = oku["Ad"].ToString().Trim();
                        }
                    }
                    else
                    {
                        onay = 0;
                    }                    
                }

                if (dt.Rows.Count > 0 && onay == 1)  // dt boş değilse ve onay varsa hangi radio buton seçiliyse 
                {                                    // o radiobuttonun girişi olacak
                    if (radioButton1.Checked == true)
                    {
                        MessageBox.Show("Kullanıcı Girişi Başarılı");                          
                        Kullanici form = new Kullanici();
                        form.lblKId.Text = id.Trim();  // Giren kişiyi kaydediyorum sonraki formlara taşıyacam ve mesela satın alda giriş yapılmışsa ad soyadı oto çekicem
                        form.txtKAd.Text += " " + ad.Trim();
                        form.Show();
                        this.Hide();                                                                                 
                    }
                    else if (radioButton2.Checked == true) // Admin veya yönetci seçilmişse de onların formu açılacak
                    {
                        Admin form = new Admin();
                        form.Show();
                        this.Hide();
                    }
                    else if (radioButton3.Checked == true)
                    {
                        Yonetici form = new Yonetici();
                        form.Show();
                        this.Hide();
                    }

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

        private void btnAnaSayfaDon_Click(object sender, EventArgs e)
        {
            AnaSayfa form = new AnaSayfa(); // Ana sayfaya dönüş
            form.Show();
            this.Hide();
           
        }

        private void GirisEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Formu kapattığında komple uygulama kapansın bunu yapmazsak
            // Arka planda diğer formlar hide da çalışıyor

                Application.Exit();
        
        }

        private void btnkaydol_Click(object sender, EventArgs e)
        {
            Kayit form = new Kayit();  // Kayıt formuna gider
            form.Show();
            this.Hide();
        }

    }
}
