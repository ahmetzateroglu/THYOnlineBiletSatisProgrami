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
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }

        private void Yonetici_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Formu kapattığında komple uygulama kapansın bunu yapmazsak
            // Arka planda diğer formlar hide da çalışıyor

            Application.Exit();
        }

        private void btnUcus_Click(object sender, EventArgs e)
        {

            UcusEkle form = new UcusEkle();

            // UcusEkle formundaki label9 modifiersi public yaptım böylece geçişte
            // formu açan adminse admin yöneticiyse yonetici yazdırıyorum
            // Bu bana formu kimin açtığını gösterecek ve dönüşte de açan kişinin formuna
            // Geri döndüreceğim

            form.label9.Text = "Yonetici";
            form.Show();
            this.Hide();

            
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            GirisEkrani form = new GirisEkrani();
            form.Show();
            this.Hide();
        }

        private void btnKOnayla_Click(object sender, EventArgs e)
        {
            KOnayla form = new KOnayla();

            // KOnayla formundaki label1 modifiersi public yaptım böylece geçişte
            // formu açan adminse admin yöneticiyse yonetici yazdırıyorum
            // Bu bana formu kimin açtığını gösterecek ve dönüşte de açan kişinin formuna
            // Geri döndüreceğim
            form.label1.Text = "Yonetici"; 
            form.Show();
            this.Hide();
        }

        private void btnAOnayla_Click(object sender, EventArgs e)
        {
            AOnayla form = new AOnayla();
            form.Show();
            this.Hide();
        }

        private void btnYOnayla_Click(object sender, EventArgs e)
        {
            YOnayla form = new YOnayla();
            form.Show();
            this.Hide();
        }

        private void btnSatisGor_Click(object sender, EventArgs e)
        {
            SatislariGor form = new SatislariGor(); // Bu ortak diye kim açıyor onu bu forma taşıyorum ki geri dönüş yerini bileyim
            form.label1.Text = "Yonetici";
            form.Show();
            this.Hide();
        }
    }
}
