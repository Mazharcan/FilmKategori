namespace FilmManager
{
    partial class Film
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.filmKategoriDataSet = new FilmManager.FilmKategoriDataSet();
            this.filmKategoriDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmKategoriDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtAra = new System.Windows.Forms.TextBox();
            this.kategorilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorilerTableAdapter = new FilmManager.FilmKategoriDataSetTableAdapters.KategorilerTableAdapter();
            this.cmbAlan = new System.Windows.Forms.ComboBox();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter = new FilmManager.FilmKategoriDataSetTableAdapters.FilmTableAdapter();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.kategorilerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.filmKayıtDataSet = new FilmManager.FilmKayıtDataSet();
            this.filmKayıtDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorilerTableAdapter1 = new FilmManager.FilmKayıtDataSetTableAdapters.KategorilerTableAdapter();
            this.dateYapımYılı = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKategoriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKategoriDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKategoriDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKayıtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKayıtDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 78);
            this.label1.TabIndex = 20;
            this.label1.Text = "FİLM ARA";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAra.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAra.Location = new System.Drawing.Point(391, 262);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(153, 43);
            this.btnAra.TabIndex = 37;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 339);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(615, 248);
            this.dataGridView1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(22, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 33);
            this.label2.TabIndex = 30;
            this.label2.Text = "Aramak İstediğiniz Alanı Seçin :";
            // 
            // filmKategoriDataSet
            // 
            this.filmKategoriDataSet.DataSetName = "FilmKategoriDataSet";
            this.filmKategoriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmKategoriDataSetBindingSource
            // 
            this.filmKategoriDataSetBindingSource.DataSource = this.filmKategoriDataSet;
            this.filmKategoriDataSetBindingSource.Position = 0;
            // 
            // filmKategoriDataSetBindingSource1
            // 
            this.filmKategoriDataSetBindingSource1.DataSource = this.filmKategoriDataSet;
            this.filmKategoriDataSetBindingSource1.Position = 0;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(391, 171);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(236, 20);
            this.txtAra.TabIndex = 3;
            this.txtAra.MouseLeave += new System.EventHandler(this.txtAra_MouseLeave);
            this.txtAra.MouseHover += new System.EventHandler(this.txtAra_MouseHover);
            // 
            // kategorilerBindingSource
            // 
            this.kategorilerBindingSource.DataMember = "Kategoriler";
            this.kategorilerBindingSource.DataSource = this.filmKategoriDataSet;
            // 
            // kategorilerTableAdapter
            // 
            this.kategorilerTableAdapter.ClearBeforeFill = true;
            // 
            // cmbAlan
            // 
            this.cmbAlan.FormattingEnabled = true;
            this.cmbAlan.Items.AddRange(new object[] {
            "Film Adı",
            "Film Yönetmeni",
            "Film Yapım Yılı",
            "Kategori"});
            this.cmbAlan.Location = new System.Drawing.Point(391, 134);
            this.cmbAlan.Name = "cmbAlan";
            this.cmbAlan.Size = new System.Drawing.Size(236, 21);
            this.cmbAlan.TabIndex = 1;
            this.cmbAlan.SelectedIndexChanged += new System.EventHandler(this.cmbAlan_SelectedIndexChanged_1);
            this.cmbAlan.MouseLeave += new System.EventHandler(this.cmbAlan_MouseLeave);
            this.cmbAlan.MouseHover += new System.EventHandler(this.cmbAlan_MouseHover);
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.filmKategoriDataSetBindingSource1;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // cmbKategori
            // 
            this.cmbKategori.DataSource = this.kategorilerBindingSource1;
            this.cmbKategori.DisplayMember = "Kategori";
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(391, 197);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(236, 21);
            this.cmbKategori.TabIndex = 38;
            this.cmbKategori.MouseLeave += new System.EventHandler(this.cmbKategori_MouseLeave);
            this.cmbKategori.MouseHover += new System.EventHandler(this.cmbKategori_MouseHover);
            // 
            // kategorilerBindingSource1
            // 
            this.kategorilerBindingSource1.DataMember = "Kategoriler";
            this.kategorilerBindingSource1.DataSource = this.filmKayıtDataSet;
            // 
            // filmKayıtDataSet
            // 
            this.filmKayıtDataSet.DataSetName = "FilmKayıtDataSet";
            this.filmKayıtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmKayıtDataSetBindingSource
            // 
            this.filmKayıtDataSetBindingSource.DataSource = this.filmKayıtDataSet;
            this.filmKayıtDataSetBindingSource.Position = 0;
            // 
            // kategorilerTableAdapter1
            // 
            this.kategorilerTableAdapter1.ClearBeforeFill = true;
            // 
            // dateYapımYılı
            // 
            this.dateYapımYılı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateYapımYılı.Location = new System.Drawing.Point(391, 224);
            this.dateYapımYılı.Name = "dateYapımYılı";
            this.dateYapımYılı.Size = new System.Drawing.Size(200, 22);
            this.dateYapımYılı.TabIndex = 40;
            // 
            // Film
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(648, 607);
            this.Controls.Add(this.dateYapımYılı);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.cmbAlan);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Film";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Film_FormClosing);
            this.Load += new System.EventHandler(this.Film_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKategoriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKategoriDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKategoriDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKayıtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKayıtDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource filmKategoriDataSetBindingSource;
        private FilmKategoriDataSet filmKategoriDataSet;
        private System.Windows.Forms.BindingSource filmKategoriDataSetBindingSource1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.BindingSource kategorilerBindingSource;
        private FilmKategoriDataSetTableAdapters.KategorilerTableAdapter kategorilerTableAdapter;
        private System.Windows.Forms.ComboBox cmbAlan;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private FilmKategoriDataSetTableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.BindingSource filmKayıtDataSetBindingSource;
        private FilmKayıtDataSet filmKayıtDataSet;
        private System.Windows.Forms.BindingSource kategorilerBindingSource1;
        private FilmKayıtDataSetTableAdapters.KategorilerTableAdapter kategorilerTableAdapter1;
        private System.Windows.Forms.DateTimePicker dateYapımYılı;
    }
}