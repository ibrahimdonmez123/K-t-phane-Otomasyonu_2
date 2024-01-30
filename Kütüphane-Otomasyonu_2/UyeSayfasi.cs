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
    public partial class UyeSayfasi : Form
    {
        List<Kitap> Kitaplar;
        public UyeSayfasi(List<Kitap> Kitaplar)
        {
            InitializeComponent();
            this.Kitaplar = Kitaplar;
        }

        private void kitaplistesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UyeSayfasi_Load(object sender, EventArgs e)
        {
            foreach (Kitap kitap in Kitaplar)
            {
                kitaplistesi.Rows.Add(kitap.getisim() , kitap.getid() , kitap.getyazari() , kitap.getbasimyili() , kitap.getkonusu() , kitap.getadet());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
            MessageBox.Show("Çıkış yapılıyor...");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int kitapid;
            kitapid = Convert.ToInt32(txt_kitapid.Text);

            Kitap Hedefkitap;

            foreach (Kitap kitap in Kitaplar)
            {
                if(kitap.getid() == kitapid)
                {
                    Hedefkitap = kitap;

                    kitaplistesi.Rows.Clear();
                    kitaplistesi.Rows.Add(Hedefkitap.getisim(), Hedefkitap.getid(), Hedefkitap.getyazari(), Hedefkitap.getbasimyili(), Hedefkitap.getkonusu(), Hedefkitap.getadet());
                }
            }
        }
    }
}
