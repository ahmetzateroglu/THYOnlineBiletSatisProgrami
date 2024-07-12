using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Ahmet Zateroğlu 200707025

namespace THY
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnUcus_Click(object sender, EventArgs e)
        {

            UcusEkle form = new UcusEkle();

            // UcusEkle formundaki label9 modifiersi public yaptım böylece geçişte
            // formu açan adminse admin yöneticiyse yonetici yazdırıyorum
            // Bu bana formu kimin açtığını gösterecek ve dönüşte de açan kişinin formuna
            // Geri döndüreceğim

            form.label9.Text = "Admin";
            form.Show();
            this.Hide();

        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            GirisEkrani form = new GirisEkrani(); // Giriş Ekranına Döner
            form.Show();
            this.Hide();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Formu kapattığında komple uygulama kapansın bunu yapmazsak
            // Arka planda diğer formlar hide da çalışıyor

            Application.Exit();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnKOnayla_Click(object sender, EventArgs e)
        {
            KOnayla form = new KOnayla();
            // KOnayla formundaki label1 modifiersi public yaptım böylece geçişte
            // formu açan adminse admin yöneticiyse yonetici yazdırıyorum
            // Bu bana formu kimin açtığını gösterecek ve dönüşte de açan kişinin formuna
            // Geri döndüreceğim
            form.label1.Text = "Admin";
            form.Show();
            this.Hide();
        }

        private void btnSatisGor_Click(object sender, EventArgs e)
        {
            // SatislariGor formundaki label1 modifiersi public yaptım böylece geçişte
            // formu açan adminse admin yöneticiyse yonetici yazdırıyorum
            // Bu bana formu kimin açtığını gösterecek ve dönüşte de açan kişinin formuna
            // Geri döndüreceğim
            SatislariGor form = new SatislariGor();
            form.label1.Text = "Admin";
            form.Show();
            this.Hide();
        }
    }
}
