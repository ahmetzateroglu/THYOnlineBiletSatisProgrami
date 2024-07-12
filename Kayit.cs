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
// Ahmet Zateroğlu 200707025
namespace THY
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }
        // Burada kayıt ekleme kısmı yapılacak
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JIKNC4U;Initial Catalog=THY;Integrated Security=True");

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                string komutYazisi = "Insert into Tbl_Kullanici (KullaniciAdi,KullaniciSifre,Durum,Ad,Soyad,KimlikNo,Telefon) values (@k1,@k2,@k3,@k4,@k5,@k6,@k7)";

                // Seçilen radiobuttona göre sorgu gelicek admin kullanıcı veya yöetici
                if (radioButton1.Checked == true)
                {
                    komutYazisi = "Insert into Tbl_Kullanici (KullaniciAdi,KullaniciSifre,Durum,Ad,Soyad,KimlikNo,Telefon) values (@k1,@k2,@k3,@k4,@k5,@k6,@k7)";
                }
                else if (radioButton2.Checked == true)
                {
                    komutYazisi = "Insert into Tbl_Admin (AdminAdi,AdminSifre,Durum,Ad,Soyad,KimlikNo,Telefon) values (@k1,@k2,@k3,@k4,@k5,@k6,@k7)";
                }
                else if (radioButton3.Checked == true)
                {
                    komutYazisi = "Insert into Tbl_Yonetici (YoneticiAdi,YoneticiSifre,Durum,Ad,Soyad,KimlikNo,Telefon) values (@k1,@k2,@k3,@k4,@k5,@k6,@k7)";
                }

                SqlCommand komut = new SqlCommand(komutYazisi, baglanti);
                // Sorgu alınıyor parametreler atanıyor ve kayıt yapılıyor
                komut.Parameters.AddWithValue("@k1", textBox5.Text.Trim());
                komut.Parameters.AddWithValue("@k2", textBox6.Text.Trim());
                komut.Parameters.AddWithValue("@k3", "Onaysız".Trim());  // İlk kayıt onaysız admin veya yönetici onaylamalı
                komut.Parameters.AddWithValue("@k4", textBox1.Text.Trim());
                komut.Parameters.AddWithValue("@k5", textBox2.Text.Trim());
                komut.Parameters.AddWithValue("@k6", textBox3.Text.Trim());
                komut.Parameters.AddWithValue("@k7", textBox4.Text.Trim());
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Başarılı");
                Temizle(); // Temizleye gider

            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }

        }


        private void Temizle()
        {

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";


        }

        private void Kayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Formu kapattığında komple uygulama kapansın bunu yapmazsak
            // Arka planda diğer formlar hide da çalışıyor

            Application.Exit();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            GirisEkrani form = new GirisEkrani();  // Giriş ekranına geri döner
            form.Show();
            this.Hide();
        }
    }
}
