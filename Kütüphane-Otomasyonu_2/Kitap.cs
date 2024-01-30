using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Otomasyonu_2
{
    public class Kitap
    {

        public string isim { get; set; }
        public int id { get; set; }
        public string yazari { get; set; }
        public int basimyili { get; set; }
        public string konusu { get; set; }
        public int adet { get; set; }

        public Kitap()
        {

        }
        public Kitap(string isim, int id, string yazari, int basimyili, string konusu, int adet )
        {
            this.isim = isim;
            this.id = id;
            this.yazari = yazari;
            this.basimyili = basimyili;
            this.konusu = konusu;
            this.adet = adet;
        }

        public void setisim()
        {
            this.isim = isim;
        }
        public string getisim()
        {
            return this.isim;
        }
        public void setid()
        {
            this.id = id;
        }
        public int getid()
        { 
            return this.id; 
        } 
        public void setyazari()
        {
            this.yazari = yazari;
        }
        public string getyazari()
        {
            return this.yazari;
        }
        public void setbasimyili()
        {
            this.basimyili=basimyili;   
        }
        public int getbasimyili()
        {
            return this.basimyili;
        }
        public void setkonusu()
        { 
          this.konusu=konusu;
        }

        public string getkonusu()
        {
            return this.konusu;
        }
        public void setadet()
        {
            this.adet = adet;
        }
        public int getadet()
        {
            return this.adet;
        }
    }
}
