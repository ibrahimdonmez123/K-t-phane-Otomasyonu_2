using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu_2
{
    public partial class Form1 : Form
    {
        List<Kisi> Kisiler = new List<Kisi>();
        List<Kitap> Kitaplar = new List<Kitap>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullanici_adi.Text = string.Empty;
            txt_sifre.Text = string.Empty;
        }

        private void btn_giris_yap_Click(object sender, EventArgs e)
        {
            string kullaniciadi;
            int sifre;

            kullaniciadi = txt_kullanici_adi.Text;
            sifre = Convert.ToInt32(txt_sifre.Text);

            bool kontrol = false;

            foreach (Kisi kisi in Kisiler)
            {

                if (kullaniciadi.ToLower() == kisi.getkullaniciadi() && sifre == kisi.getsifre() && kisi.getyetki() == "admin")
                {
                    kontrol = true;
                    AdminSayfasi adminsayfasi = new AdminSayfasi(Kisiler, Kitaplar);
                    adminsayfasi.Show();
                    this.Hide();

                }

                else if (kullaniciadi.ToLower() == kisi.getkullaniciadi() && sifre == kisi.getsifre() && kisi.getyetki() == "üye")
                {
                    kontrol = true;
                    UyeSayfasi uyesayfasi = new UyeSayfasi(Kitaplar);
                    uyesayfasi.Show();
                    this.Hide();

                }

            }

            if (!kontrol)
            {
                MessageBox.Show("Girdiğiniz şifre yanlış", "Eroor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kisiler.Add(new Kisi("ahmet", "ceylan", 123 ,  45, "kitapkurdu", "admin", 1));
            Kisiler.Add(new Kisi("kemal", "demir", 234, 35, "kitapçı", "üye", 2));
            Kisiler.Add(new Kisi("yüksel", "sevinç", 345, 25, "savaşçı", "üye", 3));
            Kisiler.Add(new Kisi("necati", "özoğlu", 456, 34, "excalibur17", "üye", 4));

            Kitaplar.Add(new Kitap("Ateşle dans ", 1, "mahmut cansuyu", 2000, "aşk", 100));
            Kitaplar.Add(new Kitap("Kar tatili ", 2, "mehmet kaya", 1888, "tarih", 200));
            Kitaplar.Add(new Kitap("şatoda gece ", 3, "elif güleru", 2010, "strateji", 150));
            Kitaplar.Add(new Kitap("3 mayöun ", 4, "kazım şahin", 1996, "korku", 75));

        }
    }
}