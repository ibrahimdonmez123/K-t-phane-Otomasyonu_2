namespace Kütüphane_Otomasyonu_2
{
    partial class AdminSayfasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.adminkisilistesi = new System.Windows.Forms.DataGridView();
            this.İsim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OlusturmaTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullaniciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yetki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.İd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminkitaplistesi = new System.Windows.Forms.DataGridView();
            this.kitapisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yazari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BasimYili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Konusu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_kisi_id = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txt_kitap_id = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_kullanici_adi = new System.Windows.Forms.TextBox();
            this.txt_kisi_idd = new System.Windows.Forms.TextBox();
            this.txt_kisi_yetki = new System.Windows.Forms.TextBox();
            this.txt_kisi_yas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_kisi_sifre = new System.Windows.Forms.TextBox();
            this.txt_kisi_soyisim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_kisi_isim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_kitap_adet = new System.Windows.Forms.TextBox();
            this.txt_kitap_yazar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_kitap_basimyili = new System.Windows.Forms.TextBox();
            this.txt_kitap_isim = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_kitap_konu = new System.Windows.Forms.TextBox();
            this.txt_kitap_idd = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adminkisilistesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminkitaplistesi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminkisilistesi
            // 
            this.adminkisilistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminkisilistesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.İsim,
            this.Soyisim,
            this.Sifre,
            this.OlusturmaTarihi,
            this.Yas,
            this.KullaniciAdi,
            this.Yetki,
            this.İd});
            this.adminkisilistesi.Location = new System.Drawing.Point(12, 42);
            this.adminkisilistesi.Name = "adminkisilistesi";
            this.adminkisilistesi.Size = new System.Drawing.Size(389, 226);
            this.adminkisilistesi.TabIndex = 0;
            this.adminkisilistesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminkisilistesi_CellClick);
            this.adminkisilistesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // İsim
            // 
            this.İsim.HeaderText = "İSİM";
            this.İsim.Name = "İsim";
            // 
            // Soyisim
            // 
            this.Soyisim.HeaderText = "SOYİSİM";
            this.Soyisim.Name = "Soyisim";
            // 
            // Sifre
            // 
            this.Sifre.HeaderText = "SİFRE";
            this.Sifre.Name = "Sifre";
            // 
            // OlusturmaTarihi
            // 
            this.OlusturmaTarihi.HeaderText = "OLUSTURMA TARİHİ";
            this.OlusturmaTarihi.Name = "OlusturmaTarihi";
            // 
            // Yas
            // 
            this.Yas.HeaderText = "YAS";
            this.Yas.Name = "Yas";
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.HeaderText = "KULLANICI ADI";
            this.KullaniciAdi.Name = "KullaniciAdi";
            // 
            // Yetki
            // 
            this.Yetki.HeaderText = "YETKİ";
            this.Yetki.Name = "Yetki";
            // 
            // İd
            // 
            this.İd.HeaderText = "İD";
            this.İd.Name = "İd";
            // 
            // adminkitaplistesi
            // 
            this.adminkitaplistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminkitaplistesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapisim,
            this.kitapid,
            this.Yazari,
            this.BasimYili,
            this.Konusu,
            this.Adet});
            this.adminkitaplistesi.Location = new System.Drawing.Point(407, 42);
            this.adminkitaplistesi.Name = "adminkitaplistesi";
            this.adminkitaplistesi.Size = new System.Drawing.Size(381, 226);
            this.adminkitaplistesi.TabIndex = 0;
            this.adminkitaplistesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminkitaplistesi_CellClick);
            this.adminkitaplistesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminkitaplistesi_CellContentClick);
            // 
            // kitapisim
            // 
            this.kitapisim.HeaderText = "İSİM";
            this.kitapisim.Name = "kitapisim";
            // 
            // kitapid
            // 
            this.kitapid.HeaderText = "KİTAP İD";
            this.kitapid.Name = "kitapid";
            // 
            // Yazari
            // 
            this.Yazari.HeaderText = "YAZARI";
            this.Yazari.Name = "Yazari";
            // 
            // BasimYili
            // 
            this.BasimYili.HeaderText = "BASIM YILI";
            this.BasimYili.Name = "BasimYili";
            // 
            // Konusu
            // 
            this.Konusu.HeaderText = "KONUSU";
            this.Konusu.Name = "Konusu";
            // 
            // Adet
            // 
            this.Adet.HeaderText = "ADET";
            this.Adet.Name = "Adet";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "GÜNCELLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "TEMİZLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 30);
            this.button3.TabIndex = 1;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(202, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 30);
            this.button4.TabIndex = 1;
            this.button4.Text = "EKLE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_kisi_id
            // 
            this.txt_kisi_id.Location = new System.Drawing.Point(25, 13);
            this.txt_kisi_id.Name = "txt_kisi_id";
            this.txt_kisi_id.Size = new System.Drawing.Size(100, 20);
            this.txt_kisi_id.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(131, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Ara";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_kitap_id
            // 
            this.txt_kitap_id.Location = new System.Drawing.Point(408, 13);
            this.txt_kitap_id.Name = "txt_kitap_id";
            this.txt_kitap_id.Size = new System.Drawing.Size(100, 20);
            this.txt_kitap_id.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(514, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Ara";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(408, 310);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(178, 27);
            this.button7.TabIndex = 1;
            this.button7.Text = "GÜNCELLE";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(408, 274);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(181, 30);
            this.button8.TabIndex = 1;
            this.button8.Text = "SİL";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(592, 310);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(196, 27);
            this.button9.TabIndex = 1;
            this.button9.Text = "TEMİZLE";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(592, 274);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(196, 30);
            this.button10.TabIndex = 1;
            this.button10.Text = "EKLE";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(713, 10);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 4;
            this.button11.Text = "Çıkış Yap";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(254, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kisiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(635, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kitaplar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_kullanici_adi);
            this.groupBox1.Controls.Add(this.txt_kisi_idd);
            this.groupBox1.Controls.Add(this.txt_kisi_yetki);
            this.groupBox1.Controls.Add(this.txt_kisi_yas);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_kisi_sifre);
            this.groupBox1.Controls.Add(this.txt_kisi_soyisim);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_kisi_isim);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_kullanici_adi
            // 
            this.txt_kullanici_adi.Location = new System.Drawing.Point(165, 73);
            this.txt_kullanici_adi.Name = "txt_kullanici_adi";
            this.txt_kullanici_adi.Size = new System.Drawing.Size(86, 20);
            this.txt_kullanici_adi.TabIndex = 1;
            // 
            // txt_kisi_idd
            // 
            this.txt_kisi_idd.Location = new System.Drawing.Point(231, 49);
            this.txt_kisi_idd.Name = "txt_kisi_idd";
            this.txt_kisi_idd.Size = new System.Drawing.Size(63, 20);
            this.txt_kisi_idd.TabIndex = 1;
            // 
            // txt_kisi_yetki
            // 
            this.txt_kisi_yetki.Location = new System.Drawing.Point(288, 72);
            this.txt_kisi_yetki.Name = "txt_kisi_yetki";
            this.txt_kisi_yetki.Size = new System.Drawing.Size(63, 20);
            this.txt_kisi_yetki.TabIndex = 1;
            // 
            // txt_kisi_yas
            // 
            this.txt_kisi_yas.Location = new System.Drawing.Point(160, 45);
            this.txt_kisi_yas.Name = "txt_kisi_yas";
            this.txt_kisi_yas.Size = new System.Drawing.Size(24, 20);
            this.txt_kisi_yas.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "İd";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kullanıcı Adı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Yetki";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Yas";
            // 
            // txt_kisi_sifre
            // 
            this.txt_kisi_sifre.Location = new System.Drawing.Point(40, 69);
            this.txt_kisi_sifre.Name = "txt_kisi_sifre";
            this.txt_kisi_sifre.Size = new System.Drawing.Size(62, 20);
            this.txt_kisi_sifre.TabIndex = 1;
            // 
            // txt_kisi_soyisim
            // 
            this.txt_kisi_soyisim.Location = new System.Drawing.Point(54, 45);
            this.txt_kisi_soyisim.Name = "txt_kisi_soyisim";
            this.txt_kisi_soyisim.Size = new System.Drawing.Size(72, 20);
            this.txt_kisi_soyisim.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sifre";
            // 
            // txt_kisi_isim
            // 
            this.txt_kisi_isim.Location = new System.Drawing.Point(37, 19);
            this.txt_kisi_isim.Name = "txt_kisi_isim";
            this.txt_kisi_isim.Size = new System.Drawing.Size(76, 20);
            this.txt_kisi_isim.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "İsim";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_kitap_adet);
            this.groupBox2.Controls.Add(this.txt_kitap_yazar);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_kitap_basimyili);
            this.groupBox2.Controls.Add(this.txt_kitap_isim);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_kitap_konu);
            this.groupBox2.Controls.Add(this.txt_kitap_idd);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(408, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txt_kitap_adet
            // 
            this.txt_kitap_adet.Location = new System.Drawing.Point(203, 80);
            this.txt_kitap_adet.Name = "txt_kitap_adet";
            this.txt_kitap_adet.Size = new System.Drawing.Size(101, 20);
            this.txt_kitap_adet.TabIndex = 1;
            // 
            // txt_kitap_yazar
            // 
            this.txt_kitap_yazar.Location = new System.Drawing.Point(47, 47);
            this.txt_kitap_yazar.Name = "txt_kitap_yazar";
            this.txt_kitap_yazar.Size = new System.Drawing.Size(95, 20);
            this.txt_kitap_yazar.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "İsim";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Yazarı";
            // 
            // txt_kitap_basimyili
            // 
            this.txt_kitap_basimyili.Location = new System.Drawing.Point(214, 49);
            this.txt_kitap_basimyili.Name = "txt_kitap_basimyili";
            this.txt_kitap_basimyili.Size = new System.Drawing.Size(90, 20);
            this.txt_kitap_basimyili.TabIndex = 1;
            // 
            // txt_kitap_isim
            // 
            this.txt_kitap_isim.Location = new System.Drawing.Point(44, 23);
            this.txt_kitap_isim.Name = "txt_kitap_isim";
            this.txt_kitap_isim.Size = new System.Drawing.Size(99, 20);
            this.txt_kitap_isim.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Konusu";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(157, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Adet";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(165, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "İd";
            // 
            // txt_kitap_konu
            // 
            this.txt_kitap_konu.Location = new System.Drawing.Point(62, 74);
            this.txt_kitap_konu.Name = "txt_kitap_konu";
            this.txt_kitap_konu.Size = new System.Drawing.Size(80, 20);
            this.txt_kitap_konu.TabIndex = 1;
            // 
            // txt_kitap_idd
            // 
            this.txt_kitap_idd.Location = new System.Drawing.Point(183, 27);
            this.txt_kitap_idd.Name = "txt_kitap_idd";
            this.txt_kitap_idd.Size = new System.Drawing.Size(121, 20);
            this.txt_kitap_idd.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(157, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Basım Yılı";
            // 
            // AdminSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txt_kitap_id);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txt_kisi_id);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adminkitaplistesi);
            this.Controls.Add(this.adminkisilistesi);
            this.Name = "AdminSayfasi";
            this.Text = "AdminSayfasi";
            this.Load += new System.EventHandler(this.AdminSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminkisilistesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminkitaplistesi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView adminkisilistesi;
        private System.Windows.Forms.DataGridView adminkitaplistesi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_kisi_id;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt_kitap_id;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridViewTextBoxColumn İsim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn OlusturmaTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yas;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yetki;
        private System.Windows.Forms.DataGridViewTextBoxColumn İd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yazari;
        private System.Windows.Forms.DataGridViewTextBoxColumn BasimYili;
        private System.Windows.Forms.DataGridViewTextBoxColumn Konusu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_kullanici_adi;
        private System.Windows.Forms.TextBox txt_kisi_idd;
        private System.Windows.Forms.TextBox txt_kisi_yetki;
        private System.Windows.Forms.TextBox txt_kisi_yas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_kisi_sifre;
        private System.Windows.Forms.TextBox txt_kisi_soyisim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_kisi_isim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_kitap_adet;
        private System.Windows.Forms.TextBox txt_kitap_yazar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_kitap_basimyili;
        private System.Windows.Forms.TextBox txt_kitap_isim;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_kitap_konu;
        private System.Windows.Forms.TextBox txt_kitap_idd;
        private System.Windows.Forms.Label label15;
    }
}