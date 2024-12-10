namespace StokTakipProgramı
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtÜrünadi = new System.Windows.Forms.Label();
            this.txtaciklama = new System.Windows.Forms.Label();
            this.txtkategori = new System.Windows.Forms.Label();
            this.txtstokadedi = new System.Windows.Forms.Label();
            this.rtbaciklama = new System.Windows.Forms.RichTextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtTedarikçi = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // txtÜrünadi
            // 
            this.txtÜrünadi.AutoSize = true;
            this.txtÜrünadi.Location = new System.Drawing.Point(61, 56);
            this.txtÜrünadi.Name = "txtÜrünadi";
            this.txtÜrünadi.Size = new System.Drawing.Size(48, 13);
            this.txtÜrünadi.TabIndex = 4;
            this.txtÜrünadi.Text = "Ürün Adı";
            // 
            // txtaciklama
            // 
            this.txtaciklama.AutoSize = true;
            this.txtaciklama.Location = new System.Drawing.Point(60, 202);
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(50, 13);
            this.txtaciklama.TabIndex = 5;
            this.txtaciklama.Text = "Açıklama";
            // 
            // txtkategori
            // 
            this.txtkategori.AutoSize = true;
            this.txtkategori.Location = new System.Drawing.Point(364, 32);
            this.txtkategori.Name = "txtkategori";
            this.txtkategori.Size = new System.Drawing.Size(49, 13);
            this.txtkategori.TabIndex = 9;
            this.txtkategori.Text = "Kategori:";
            // 
            // txtstokadedi
            // 
            this.txtstokadedi.AutoSize = true;
            this.txtstokadedi.Location = new System.Drawing.Point(363, 196);
            this.txtstokadedi.Name = "txtstokadedi";
            this.txtstokadedi.Size = new System.Drawing.Size(62, 13);
            this.txtstokadedi.TabIndex = 10;
            this.txtstokadedi.Text = "Stok Adedi:";
            // 
            // rtbaciklama
            // 
            this.rtbaciklama.Location = new System.Drawing.Point(160, 155);
            this.rtbaciklama.Name = "rtbaciklama";
            this.rtbaciklama.Size = new System.Drawing.Size(100, 96);
            this.rtbaciklama.TabIndex = 11;
            this.rtbaciklama.Text = "";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.BackgroundImage")));
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuncelle.Location = new System.Drawing.Point(618, 261);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(149, 35);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "GÜNCELLE;";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSil.BackgroundImage")));
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSil.Location = new System.Drawing.Point(463, 261);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(149, 35);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEkle.BackgroundImage")));
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEkle.Location = new System.Drawing.Point(308, 261);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(149, 35);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnYeni
            // 
            this.btnYeni.BackgroundImage = global::StokTakipProgramı.Properties.Resources.download;
            this.btnYeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYeni.Location = new System.Drawing.Point(195, 273);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 23);
            this.btnYeni.TabIndex = 12;
            this.btnYeni.Text = "YENİ KAYIT";
            this.btnYeni.UseVisualStyleBackColor = true;
            // 
            // txtTedarikçi
            // 
            this.txtTedarikçi.AutoSize = true;
            this.txtTedarikçi.Location = new System.Drawing.Point(650, 35);
            this.txtTedarikçi.Name = "txtTedarikçi";
            this.txtTedarikçi.Size = new System.Drawing.Size(54, 13);
            this.txtTedarikçi.TabIndex = 16;
            this.txtTedarikçi.Text = "Tedarikçi:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.AutoSize = true;
            this.txtFiyat.Location = new System.Drawing.Point(650, 196);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(34, 13);
            this.txtFiyat.TabIndex = 17;
            this.txtFiyat.Text = "Fiyatı:";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(755, 185);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(120, 30);
            this.listBox4.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(754, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(454, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 21;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(454, 194);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-55, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 176);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 24);
            this.button1.TabIndex = 24;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtTedarikçi);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.rtbaciklama);
            this.Controls.Add(this.txtstokadedi);
            this.Controls.Add(this.txtkategori);
            this.Controls.Add(this.txtaciklama);
            this.Controls.Add(this.txtÜrünadi);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "ÜRÜN İŞLEMLERİ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtÜrünadi;
        private System.Windows.Forms.Label txtaciklama;
        private System.Windows.Forms.Label txtkategori;
        private System.Windows.Forms.Label txtstokadedi;
        private System.Windows.Forms.RichTextBox rtbaciklama;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label txtTedarikçi;
        private System.Windows.Forms.Label txtFiyat;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}