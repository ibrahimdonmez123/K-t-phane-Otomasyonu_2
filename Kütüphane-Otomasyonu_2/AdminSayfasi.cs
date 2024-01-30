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


    public partial class AdminSayfasi : Form
    {
        List<Kisi> Kisiler;
        List<Kitap> Kitaplar;

        public AdminSayfasi(List<Kisi> Kisiler, List<Kitap> Kitaplar)
        {
            InitializeComponent();
            this.Kisiler = Kisiler;
            this.Kitaplar = Kitaplar;
        }

        public void textleridoldurkisi()
        {
            txt_kisi_isim.Text = adminkisilistesi.CurrentRow.Cells[0].Value.ToString();
            txt_kisi_soyisim.Text = adminkisilistesi.CurrentRow.Cells[1].Value.ToString();
            txt_kisi_sifre.Text = adminkisilistesi.CurrentRow.Cells[2].Value.ToString();
            txt_kisi_yas.Text = adminkisilistesi.CurrentRow.Cells[4].Value.ToString();  
            txt_kullanici_adi.Text = adminkisilistesi.CurrentRow.Cells[5].Value.ToString(); 
            txt_kisi_yetki.Text = adminkisilistesi.CurrentRow.Cells[6].Value.ToString();
            txt_kisi_idd.Text = adminkisilistesi.CurrentRow.Cells[7].Value.ToString();

        }
        public void textleridoldurkitap()
        {
            txt_kitap_isim.Text = adminkitaplistesi.CurrentRow.Cells[0].Value.ToString();
            txt_kitap_idd.Text = adminkitaplistesi.CurrentRow.Cells[1].Value.ToString();
            txt_kitap_yazar.Text = adminkitaplistesi.CurrentRow.Cells[2].Value.ToString();
            txt_kitap_basimyili.Text = adminkitaplistesi.CurrentRow.Cells[3].Value.ToString();
            txt_kitap_konu.Text = adminkitaplistesi.CurrentRow.Cells[4].Value.ToString();
            txt_kitap_adet.Text = adminkitaplistesi.CurrentRow.Cells[5].Value.ToString();
        }
        private void AdminSayfasi_Load(object sender, EventArgs e)
        {
            foreach (Kisi kisi in Kisiler)
            {
                adminkisilistesi.Rows.Add(kisi.getisim(), kisi.getsoyisim(), kisi.getsifre(), kisi.getyas(), kisi.getkullaniciadi(), kisi.getyetki(), kisi.getid());
            }
            foreach (Kitap kitap in Kitaplar)
            {
                adminkitaplistesi.Rows.Add(kitap.getisim(), kitap.getid(), kitap.getyazari(), kitap.getbasimyili(), kitap.getkonusu(), kitap.getadet());
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int kisiid;
            kisiid = Convert.ToInt32(txt_kisi_id.Text);

            foreach (Kisi kisi in Kisiler)
            {
                Kisi hedefkisi;

                if (kisiid == kisi.getid())
                {
                    hedefkisi = kisi;

                    adminkisilistesi.Rows.Clear();
                    adminkisilistesi.Rows.Add(hedefkisi.getisim(), hedefkisi.getsoyisim(), hedefkisi.getsifre(),hedefkisi.getyas(), hedefkisi.getkullaniciadi(), hedefkisi.getyetki(), hedefkisi.getid());
                }

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int kitapid;

            kitapid = Convert.ToInt32(txt_kitap_id.Text);

            foreach (Kitap kitap in Kitaplar)
            {
                Kitap hedefkitap;

                if (kitapid == kitap.getid())
                {
                    hedefkitap = kitap;

                    adminkitaplistesi.Rows.Clear();
                    adminkitaplistesi.Rows.Add(hedefkitap.getisim(), hedefkitap.getisim(), hedefkitap.getyazari(), hedefkitap.getbasimyili(), hedefkitap.getkonusu(), hedefkitap.getadet());
                }
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminkisilistesi.Rows.Remove(adminkisilistesi.CurrentRow);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            adminkitaplistesi.Rows.Remove(adminkitaplistesi.CurrentRow);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                groupBox1.Controls[i].Text = string.Empty;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox2.Controls.Count; i++)
            {
                groupBox2.Controls[i].Text = string.Empty;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminkisilistesi.Rows.Add(txt_kisi_isim.Text, txt_kisi_soyisim.Text, txt_kisi_sifre.Text, txt_kisi_yas.Text, txt_kisi_yas.Text, txt_kullanici_adi.Text, txt_kisi_yetki.Text, txt_kitap_id);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            adminkitaplistesi.Rows.Add(txt_kitap_isim.Text, txt_kitap_idd.Text, txt_kitap_yazar.Text, txt_kitap_basimyili.Text, txt_kitap_konu.Text, txt_kitap_adet.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void adminkisilistesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleridoldurkisi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim = txt_kisi_isim.Text;
            string soyisim = txt_kisi_soyisim.Text;
            string  sifre = txt_kisi_sifre.Text;
            string yas = txt_kisi_yas.Text;
            string kullaniciadi = txt_kullanici_adi.Text;  
            string yetki = txt_kisi_yetki.Text;
            string id = txt_kisi_id.Text;

            adminkisilistesi.Rows.Remove(adminkisilistesi.CurrentRow);
            adminkisilistesi.Rows.Add(isim, soyisim, sifre,  yas, kullaniciadi, yetki, id);


        }

        private void adminkitaplistesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleridoldurkitap();
        }

        private void adminkitaplistesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kitapisim = txt_kitap_isim.Text;
            string kitapid = txt_kitap_id.Text;
            string kitapyazar = txt_kitap_yazar.Text;
            string kitapnbasimyili = txt_kitap_basimyili.Text;
            string kitapkonusu  = txt_kitap_konu.Text;
            string kitapidd = txt_kitap_idd.Text;

            adminkitaplistesi.Rows.Remove(adminkitaplistesi.CurrentRow);
            adminkitaplistesi.Rows.Add(kitapisim, kitapid, kitapyazar, kitapnbasimyili, kitapkonusu, kitapidd); 

        }
    }
}
