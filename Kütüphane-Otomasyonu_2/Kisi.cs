using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu_2
{
    public class Kisi
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int sifre { get; set; }
        public int yas { get; set; }
        public string kullaniciadi { get; set; }
        public string yetki { get; set; }
        public int id { get; set; }



        public Kisi()
        {

        }

        public Kisi(string isim ,string soyisim , int sifre  ,int yas  ,string kullaniciadi, string yetki , int id)
        {
            this.isim = isim;
            this.soyisim= soyisim;
            this.sifre = sifre;
            this.yas = yas;
            this.kullaniciadi= kullaniciadi;    
            this.yetki= yetki;
            this.id = id;   
        }

        public void setisim()
        {
            this.isim = isim;   
        }

        public string getisim()
        {
            return this.isim;   
        }

        public void setsoyisim()
        {
            this.soyisim = soyisim;
        }
        public string getsoyisim()
        {
            return this.soyisim;    
        }
        public void setsifre()
        {
            this.sifre = sifre;
        }

        public int getsifre()
        {
            return this.sifre;
        }
        

        public void setyas()
        {
            this.yas = yas; 
        }
        public int getyas()
        {
            return this.yas;
        }
        public void setkullaniciadi()
        {
            this.kullaniciadi = kullaniciadi;
        }
        public string getkullaniciadi()
        {
            return this.kullaniciadi;   
        }
        public void setyetki()
        {
            this.yetki = yetki; 
        }
        public string getyetki()
        {
            return this.yetki;  
        }
        public void setid()
        {
            this.id = id;   
        }
        public int getid()
        {
            return this.id; 
        }
    }

}
