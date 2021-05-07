namespace NyymProject
{
    partial class Form4
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
            this.buttonKitapEkle = new System.Windows.Forms.Button();
            this.buttonKitapCikar = new System.Windows.Forms.Button();
            this.buttonKitapGüncelle = new System.Windows.Forms.Button();
            this.dataGridKitap = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayineviidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazaridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Konu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.textBoxKitapIsim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKitapKategori = new System.Windows.Forms.TextBox();
            this.comboBoxYazar = new System.Windows.Forms.ComboBox();
            this.comboBoxYayinevi = new System.Windows.Forms.ComboBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxKonu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nyymDbDataSet = new NyymProject.nyymDbDataSet();
            this.kitapTableAdapter = new NyymProject.nyymDbDataSetTableAdapters.KitapTableAdapter();
            this.nyymDbDataSet1 = new NyymProject.nyymDbDataSet();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.buttonYayineviEkle = new System.Windows.Forms.Button();
            this.buttonYazarEkle = new System.Windows.Forms.Button();
            this.textBoxYazarEkle = new System.Windows.Forms.TextBox();
            this.textBoxYayineviEkle = new System.Windows.Forms.TextBox();
            this.nyymDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyymDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyymDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyymDbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKitapEkle
            // 
            this.buttonKitapEkle.Location = new System.Drawing.Point(58, 207);
            this.buttonKitapEkle.Name = "buttonKitapEkle";
            this.buttonKitapEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonKitapEkle.TabIndex = 0;
            this.buttonKitapEkle.Text = "ekle";
            this.buttonKitapEkle.UseVisualStyleBackColor = true;
            this.buttonKitapEkle.Click += new System.EventHandler(this.buttonKitapEkle_Click);
            // 
            // buttonKitapCikar
            // 
            this.buttonKitapCikar.Location = new System.Drawing.Point(211, 207);
            this.buttonKitapCikar.Name = "buttonKitapCikar";
            this.buttonKitapCikar.Size = new System.Drawing.Size(75, 23);
            this.buttonKitapCikar.TabIndex = 1;
            this.buttonKitapCikar.Text = "sil";
            this.buttonKitapCikar.UseVisualStyleBackColor = true;
            this.buttonKitapCikar.Click += new System.EventHandler(this.buttonKitapCikar_Click);
            // 
            // buttonKitapGüncelle
            // 
            this.buttonKitapGüncelle.Location = new System.Drawing.Point(390, 207);
            this.buttonKitapGüncelle.Name = "buttonKitapGüncelle";
            this.buttonKitapGüncelle.Size = new System.Drawing.Size(75, 23);
            this.buttonKitapGüncelle.TabIndex = 2;
            this.buttonKitapGüncelle.Text = "güncelle";
            this.buttonKitapGüncelle.UseVisualStyleBackColor = true;
            this.buttonKitapGüncelle.Click += new System.EventHandler(this.buttonKitapGüncelle_Click);
            // 
            // dataGridKitap
            // 
            this.dataGridKitap.AllowUserToAddRows = false;
            this.dataGridKitap.AllowUserToDeleteRows = false;
            this.dataGridKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKitap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.isimDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.yayineviidDataGridViewTextBoxColumn,
            this.yazaridDataGridViewTextBoxColumn,
            this.Konu,
            this.resimDataGridViewImageColumn});
            this.dataGridKitap.Location = new System.Drawing.Point(58, 249);
            this.dataGridKitap.Name = "dataGridKitap";
            this.dataGridKitap.ReadOnly = true;
            this.dataGridKitap.RowTemplate.Height = 100;
            this.dataGridKitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridKitap.Size = new System.Drawing.Size(680, 189);
            this.dataGridKitap.TabIndex = 3;
            this.dataGridKitap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridKitap_CellClick);
            this.dataGridKitap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridKitap_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // isimDataGridViewTextBoxColumn
            // 
            this.isimDataGridViewTextBoxColumn.DataPropertyName = "isim";
            this.isimDataGridViewTextBoxColumn.HeaderText = "isim";
            this.isimDataGridViewTextBoxColumn.Name = "isimDataGridViewTextBoxColumn";
            this.isimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "kategori";
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            this.kategoriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yayineviidDataGridViewTextBoxColumn
            // 
            this.yayineviidDataGridViewTextBoxColumn.DataPropertyName = "yayinevi_id";
            this.yayineviidDataGridViewTextBoxColumn.HeaderText = "yayinevi_id";
            this.yayineviidDataGridViewTextBoxColumn.Name = "yayineviidDataGridViewTextBoxColumn";
            this.yayineviidDataGridViewTextBoxColumn.ReadOnly = true;
            this.yayineviidDataGridViewTextBoxColumn.Visible = false;
            // 
            // yazaridDataGridViewTextBoxColumn
            // 
            this.yazaridDataGridViewTextBoxColumn.DataPropertyName = "yazar_id";
            this.yazaridDataGridViewTextBoxColumn.HeaderText = "yazar_id";
            this.yazaridDataGridViewTextBoxColumn.Name = "yazaridDataGridViewTextBoxColumn";
            this.yazaridDataGridViewTextBoxColumn.ReadOnly = true;
            this.yazaridDataGridViewTextBoxColumn.Visible = false;
            // 
            // Konu
            // 
            this.Konu.DataPropertyName = "konu";
            this.Konu.HeaderText = "konu";
            this.Konu.Name = "Konu";
            this.Konu.ReadOnly = true;
            // 
            // resimDataGridViewImageColumn
            // 
            this.resimDataGridViewImageColumn.DataPropertyName = "resim";
            this.resimDataGridViewImageColumn.HeaderText = "resim";
            this.resimDataGridViewImageColumn.Name = "resimDataGridViewImageColumn";
            this.resimDataGridViewImageColumn.ReadOnly = true;
            // 
            // textBoxKitapIsim
            // 
            this.textBoxKitapIsim.Location = new System.Drawing.Point(259, 32);
            this.textBoxKitapIsim.Name = "textBoxKitapIsim";
            this.textBoxKitapIsim.Size = new System.Drawing.Size(100, 20);
            this.textBoxKitapIsim.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "kitap isim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "yayinevi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "yazar";
            // 
            // textBoxKitapKategori
            // 
            this.textBoxKitapKategori.Location = new System.Drawing.Point(259, 107);
            this.textBoxKitapKategori.Name = "textBoxKitapKategori";
            this.textBoxKitapKategori.Size = new System.Drawing.Size(100, 20);
            this.textBoxKitapKategori.TabIndex = 13;
            // 
            // comboBoxYazar
            // 
            this.comboBoxYazar.FormattingEnabled = true;
            this.comboBoxYazar.Location = new System.Drawing.Point(416, 106);
            this.comboBoxYazar.Name = "comboBoxYazar";
            this.comboBoxYazar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYazar.TabIndex = 16;
            this.comboBoxYazar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxYayinevi
            // 
            this.comboBoxYayinevi.FormattingEnabled = true;
            this.comboBoxYayinevi.Location = new System.Drawing.Point(416, 35);
            this.comboBoxYayinevi.Name = "comboBoxYayinevi";
            this.comboBoxYayinevi.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYayinevi.TabIndex = 17;
            this.comboBoxYayinevi.SelectedIndexChanged += new System.EventHandler(this.comboBoxYayinevi_SelectedIndexChanged);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(58, 150);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 18;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(68, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 113);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxKonu
            // 
            this.textBoxKonu.Location = new System.Drawing.Point(563, 107);
            this.textBoxKonu.Name = "textBoxKonu";
            this.textBoxKonu.Size = new System.Drawing.Size(175, 20);
            this.textBoxKonu.TabIndex = 20;
            this.textBoxKonu.TextChanged += new System.EventHandler(this.textBoxKonu_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "kitap konu";
            // 
            // nyymDbDataSet
            // 
            this.nyymDbDataSet.DataSetName = "nyymDbDataSet";
            this.nyymDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitapTableAdapter
            // 
            this.kitapTableAdapter.ClearBeforeFill = true;
            // 
            // nyymDbDataSet1
            // 
            this.nyymDbDataSet1.DataSetName = "nyymDbDataSet";
            this.nyymDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataMember = "Kitap";
            this.kitapBindingSource.DataSource = this.nyymDbDataSet;
            this.kitapBindingSource.CurrentChanged += new System.EventHandler(this.kitapBindingSource_CurrentChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Resim";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttonYayineviEkle
            // 
            this.buttonYayineviEkle.Location = new System.Drawing.Point(528, 220);
            this.buttonYayineviEkle.Name = "buttonYayineviEkle";
            this.buttonYayineviEkle.Size = new System.Drawing.Size(89, 23);
            this.buttonYayineviEkle.TabIndex = 23;
            this.buttonYayineviEkle.Text = "yayinevi ekle";
            this.buttonYayineviEkle.UseVisualStyleBackColor = true;
            this.buttonYayineviEkle.Click += new System.EventHandler(this.buttonYayineviEkle_Click);
            // 
            // buttonYazarEkle
            // 
            this.buttonYazarEkle.Location = new System.Drawing.Point(528, 194);
            this.buttonYazarEkle.Name = "buttonYazarEkle";
            this.buttonYazarEkle.Size = new System.Drawing.Size(89, 23);
            this.buttonYazarEkle.TabIndex = 24;
            this.buttonYazarEkle.Text = "yazar ekle";
            this.buttonYazarEkle.UseVisualStyleBackColor = true;
            this.buttonYazarEkle.Click += new System.EventHandler(this.buttonYazarEkle_Click);
            // 
            // textBoxYazarEkle
            // 
            this.textBoxYazarEkle.Location = new System.Drawing.Point(638, 197);
            this.textBoxYazarEkle.Name = "textBoxYazarEkle";
            this.textBoxYazarEkle.Size = new System.Drawing.Size(100, 20);
            this.textBoxYazarEkle.TabIndex = 25;
            // 
            // textBoxYayineviEkle
            // 
            this.textBoxYayineviEkle.Location = new System.Drawing.Point(638, 223);
            this.textBoxYayineviEkle.Name = "textBoxYayineviEkle";
            this.textBoxYayineviEkle.Size = new System.Drawing.Size(100, 20);
            this.textBoxYayineviEkle.TabIndex = 26;
            // 
            // nyymDbDataSetBindingSource
            // 
            this.nyymDbDataSetBindingSource.DataSource = this.nyymDbDataSet;
            this.nyymDbDataSetBindingSource.Position = 0;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxYayineviEkle);
            this.Controls.Add(this.textBoxYazarEkle);
            this.Controls.Add(this.buttonYazarEkle);
            this.Controls.Add(this.buttonYayineviEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxKonu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.comboBoxYayinevi);
            this.Controls.Add(this.comboBoxYazar);
            this.Controls.Add(this.textBoxKitapKategori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKitapIsim);
            this.Controls.Add(this.dataGridKitap);
            this.Controls.Add(this.buttonKitapGüncelle);
            this.Controls.Add(this.buttonKitapCikar);
            this.Controls.Add(this.buttonKitapEkle);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyymDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyymDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyymDbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKitapEkle;
        private System.Windows.Forms.Button buttonKitapCikar;
        private System.Windows.Forms.Button buttonKitapGüncelle;
        private System.Windows.Forms.DataGridView dataGridKitap;
        private System.Windows.Forms.TextBox textBoxKitapIsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKitapKategori;
        private System.Windows.Forms.ComboBox comboBoxYazar;
        private System.Windows.Forms.ComboBox comboBoxYayinevi;
        private nyymDbDataSet nyymDbDataSet;
        private nyymDbDataSetTableAdapters.KitapTableAdapter kitapTableAdapter;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxKonu;
        private System.Windows.Forms.Label label5;
        private nyymDbDataSet nyymDbDataSet1;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayineviidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazaridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Konu;
        private System.Windows.Forms.DataGridViewImageColumn resimDataGridViewImageColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonYayineviEkle;
        private System.Windows.Forms.Button buttonYazarEkle;
        private System.Windows.Forms.TextBox textBoxYazarEkle;
        private System.Windows.Forms.TextBox textBoxYayineviEkle;
        private System.Windows.Forms.BindingSource nyymDbDataSetBindingSource;
    }
}