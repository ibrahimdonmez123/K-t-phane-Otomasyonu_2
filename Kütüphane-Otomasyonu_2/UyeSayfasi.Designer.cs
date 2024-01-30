namespace Kütüphane_Otomasyonu_2
{
    partial class UyeSayfasi
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
            this.kitaplistesi = new System.Windows.Forms.DataGridView();
            this.isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.İd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yazari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Basimyili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Konusu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_kitapid = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplistesi)).BeginInit();
            this.SuspendLayout();
            // 
            // kitaplistesi
            // 
            this.kitaplistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitaplistesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isim,
            this.İd,
            this.Yazari,
            this.Basimyili,
            this.Konusu,
            this.Adet});
            this.kitaplistesi.Location = new System.Drawing.Point(56, 60);
            this.kitaplistesi.Name = "kitaplistesi";
            this.kitaplistesi.Size = new System.Drawing.Size(642, 336);
            this.kitaplistesi.TabIndex = 0;
            this.kitaplistesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kitaplistesi_CellContentClick);
            // 
            // isim
            // 
            this.isim.HeaderText = "İSİM";
            this.isim.Name = "isim";
            // 
            // İd
            // 
            this.İd.HeaderText = "İD";
            this.İd.Name = "İd";
            // 
            // Yazari
            // 
            this.Yazari.HeaderText = "YAZARI";
            this.Yazari.Name = "Yazari";
            // 
            // Basimyili
            // 
            this.Basimyili.HeaderText = "BASIM YILI";
            this.Basimyili.Name = "Basimyili";
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
            this.button1.Location = new System.Drawing.Point(623, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Çıkış Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_kitapid
            // 
            this.txt_kitapid.Location = new System.Drawing.Point(56, 27);
            this.txt_kitapid.Name = "txt_kitapid";
            this.txt_kitapid.Size = new System.Drawing.Size(148, 20);
            this.txt_kitapid.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(210, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ara";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UyeSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_kitapid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kitaplistesi);
            this.Name = "UyeSayfasi";
            this.Text = "UyeSayfasi";
            this.Load += new System.EventHandler(this.UyeSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitaplistesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView kitaplistesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn İd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yazari;
        private System.Windows.Forms.DataGridViewTextBoxColumn Basimyili;
        private System.Windows.Forms.DataGridViewTextBoxColumn Konusu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_kitapid;
        private System.Windows.Forms.Button button3;
    }
}