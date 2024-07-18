namespace FilmKategori
{
    partial class frmFilm
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.filmBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.filmKategoriDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.kategorilerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.filmKayıtDataSet = new FilmKategori.FilmKayıtDataSet();
            this.kategorilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter = new FilmKategori.FilmKategoriDataSetTableAdapters.FilmTableAdapter();
            this.kategorilerTableAdapter = new FilmKategori.FilmKategoriDataSetTableAdapters.KategorilerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilmAdı = new System.Windows.Forms.TextBox();
            this.txtYonetmen = new System.Windows.Forms.TextBox();
            this.txtYapımYılı = new System.Windows.Forms.TextBox();
            this.filmKategoriDataSet1 = new FilmKategori.FilmKategoriDataSet1();
            this.filmKategoriDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmKayıtDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorilerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kategorilerTableAdapter1 = new FilmKategori.FilmKayıtDataSetTableAdapters.KategorilerTableAdapter();
            this.filmBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter1 = new FilmKategori.FilmKayıtDataSetTableAdapters.FilmTableAdapter();
            this.filmBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter2 = new FilmKategori.FilmKategoriDataSet1TableAdapters.FilmTableAdapter();
            this.kategorilerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.kategorilerTableAdapter2 = new FilmKategori.FilmKategoriDataSet1TableAdapters.KategorilerTableAdapter();
            this.filmBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.filmBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKategoriDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKayıtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKategoriDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKategoriDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKayıtDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(643, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 33);
            this.label5.TabIndex = 17;
            this.label5.Text = "Yapım Yılı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(637, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 33);
            this.label4.TabIndex = 16;
            this.label4.Text = "Yönetmen :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(655, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 33);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kategori :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(660, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 33);
            this.label2.TabIndex = 14;
            this.label2.Text = "Film Adı :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 461);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTemizle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTemizle.Location = new System.Drawing.Point(882, 435);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(153, 43);
            this.btnTemizle.TabIndex = 25;
            this.btnTemizle.Text = "YENİ";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnListele.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListele.Location = new System.Drawing.Point(772, 512);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(153, 43);
            this.btnListele.TabIndex = 24;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGüncelle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGüncelle.Location = new System.Drawing.Point(651, 435);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(153, 43);
            this.btnGüncelle.TabIndex = 23;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSil.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.Location = new System.Drawing.Point(882, 357);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(153, 43);
            this.btnSil.TabIndex = 21;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEkle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.Location = new System.Drawing.Point(651, 357);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(153, 43);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // filmBindingSource1
            // 
            this.filmBindingSource1.DataSource = this.filmKategoriDataSetBindingSource;
            // 
            // cmbKategori
            // 
            this.cmbKategori.DataSource = this.kategorilerBindingSource2;
            this.cmbKategori.DisplayMember = "Kategori";
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(798, 171);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(237, 21);
            this.cmbKategori.TabIndex = 2;
            this.cmbKategori.MouseLeave += new System.EventHandler(this.cmbKategori_MouseLeave);
            this.cmbKategori.MouseHover += new System.EventHandler(this.cmbKategori_MouseHover);
            // 
            // kategorilerBindingSource2
            // 
            this.kategorilerBindingSource2.DataMember = "Kategoriler";
            this.kategorilerBindingSource2.DataSource = this.filmKayıtDataSet;
            // 
            // filmKayıtDataSet
            // 
            this.filmKayıtDataSet.DataSetName = "FilmKayıtDataSet";
            this.filmKayıtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategorilerBindingSource
            // 
            this.kategorilerBindingSource.DataSource = this.filmKategoriDataSetBindingSource;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataSource = this.filmKategoriDataSetBindingSource;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // kategorilerTableAdapter
            // 
            this.kategorilerTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 78);
            this.label1.TabIndex = 19;
            this.label1.Text = "FİLM ARA";
            // 
            // txtFilmAdı
            // 
            this.txtFilmAdı.Location = new System.Drawing.Point(798, 106);
            this.txtFilmAdı.Name = "txtFilmAdı";
            this.txtFilmAdı.Size = new System.Drawing.Size(237, 20);
            this.txtFilmAdı.TabIndex = 1;
            this.txtFilmAdı.MouseLeave += new System.EventHandler(this.txtFilmAdı_MouseLeave);
            this.txtFilmAdı.MouseHover += new System.EventHandler(this.txtFilmAdı_MouseHover);
            // 
            // txtYonetmen
            // 
            this.txtYonetmen.Location = new System.Drawing.Point(798, 230);
            this.txtYonetmen.Name = "txtYonetmen";
            this.txtYonetmen.Size = new System.Drawing.Size(237, 20);
            this.txtYonetmen.TabIndex = 3;
            this.txtYonetmen.MouseLeave += new System.EventHandler(this.txtYonetmen_MouseLeave);
            this.txtYonetmen.MouseHover += new System.EventHandler(this.txtYonetmen_MouseHover);
            // 
            // txtYapımYılı
            // 
            this.txtYapımYılı.Location = new System.Drawing.Point(798, 290);
            this.txtYapımYılı.Name = "txtYapımYılı";
            this.txtYapımYılı.Size = new System.Drawing.Size(237, 20);
            this.txtYapımYılı.TabIndex = 4;
            this.txtYapımYılı.MouseLeave += new System.EventHandler(this.txtYapımYılı_MouseLeave);
            this.txtYapımYılı.MouseHover += new System.EventHandler(this.txtYapımYılı_MouseHover);
            // 
            // filmKategoriDataSet1
            // 
            this.filmKategoriDataSet1.DataSetName = "FilmKategoriDataSet1";
            this.filmKategoriDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmKategoriDataSet1BindingSource
            // 
            this.filmKategoriDataSet1BindingSource.DataSource = this.filmKategoriDataSet1;
            this.filmKategoriDataSet1BindingSource.Position = 0;
            // 
            // filmKayıtDataSetBindingSource
            // 
            this.filmKayıtDataSetBindingSource.DataSource = this.filmKayıtDataSet;
            this.filmKayıtDataSetBindingSource.Position = 0;
            // 
            // kategorilerBindingSource1
            // 
            this.kategorilerBindingSource1.DataMember = "Kategoriler";
            this.kategorilerBindingSource1.DataSource = this.filmKayıtDataSetBindingSource;
            // 
            // kategorilerTableAdapter1
            // 
            this.kategorilerTableAdapter1.ClearBeforeFill = true;
            // 
            // filmBindingSource2
            // 
            this.filmBindingSource2.DataMember = "Film";
            this.filmBindingSource2.DataSource = this.filmKayıtDataSetBindingSource;
            // 
            // filmTableAdapter1
            // 
            this.filmTableAdapter1.ClearBeforeFill = true;
            // 
            // filmBindingSource3
            // 
            this.filmBindingSource3.DataMember = "Film";
            this.filmBindingSource3.DataSource = this.filmKategoriDataSet1BindingSource;
            // 
            // filmTableAdapter2
            // 
            this.filmTableAdapter2.ClearBeforeFill = true;
            // 
            // kategorilerBindingSource3
            // 
            this.kategorilerBindingSource3.DataMember = "Kategoriler";
            this.kategorilerBindingSource3.DataSource = this.filmKategoriDataSet1BindingSource;
            // 
            // kategorilerTableAdapter2
            // 
            this.kategorilerTableAdapter2.ClearBeforeFill = true;
            // 
            // filmBindingSource4
            // 
            this.filmBindingSource4.DataMember = "Film";
            this.filmBindingSource4.DataSource = this.filmKayıtDataSetBindingSource;
            // 
            // filmBindingSource5
            // 
            this.filmBindingSource5.DataMember = "Film";
            this.filmBindingSource5.DataSource = this.filmKayıtDataSet;
            // 
            // frmFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1150, 637);
            this.Controls.Add(this.txtYapımYılı);
            this.Controls.Add(this.txtYonetmen);
            this.Controls.Add(this.txtFilmAdı);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFilm_FormClosing);
            this.Load += new System.EventHandler(this.frmFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKategoriDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKayıtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKategoriDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKategoriDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKayıtDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.BindingSource filmKategoriDataSetBindingSource;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private FilmKategoriDataSetTableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.BindingSource filmBindingSource1;
        private System.Windows.Forms.BindingSource kategorilerBindingSource;
        private FilmKategoriDataSetTableAdapters.KategorilerTableAdapter kategorilerTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilmAdı;
        private System.Windows.Forms.TextBox txtYonetmen;
        private System.Windows.Forms.TextBox txtYapımYılı;
        private System.Windows.Forms.BindingSource filmKayıtDataSetBindingSource;
        private FilmKayıtDataSet filmKayıtDataSet;
        private FilmKategoriDataSet1 filmKategoriDataSet1;
        private System.Windows.Forms.BindingSource filmKategoriDataSet1BindingSource;
        private System.Windows.Forms.BindingSource kategorilerBindingSource1;
        private FilmKayıtDataSetTableAdapters.KategorilerTableAdapter kategorilerTableAdapter1;
        private System.Windows.Forms.BindingSource kategorilerBindingSource2;
        private System.Windows.Forms.BindingSource filmBindingSource2;
        private FilmKayıtDataSetTableAdapters.FilmTableAdapter filmTableAdapter1;
        private System.Windows.Forms.BindingSource filmBindingSource3;
        private FilmKategoriDataSet1TableAdapters.FilmTableAdapter filmTableAdapter2;
        private System.Windows.Forms.BindingSource kategorilerBindingSource3;
        private FilmKategoriDataSet1TableAdapters.KategorilerTableAdapter kategorilerTableAdapter2;
        private System.Windows.Forms.BindingSource filmBindingSource4;
        private System.Windows.Forms.BindingSource filmBindingSource5;
    }
}