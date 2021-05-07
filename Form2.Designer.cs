namespace NyymProject
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayineviidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazaridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.Konu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Favori = new System.Windows.Forms.DataGridViewButtonColumn();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nyymDbDataSet = new NyymProject.nyymDbDataSet();
            this.buttonListele = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxYayinevi = new System.Windows.Forms.ComboBox();
            this.comboBoxYazar = new System.Windows.Forms.ComboBox();
            this.buttonListeleYazar = new System.Windows.Forms.Button();
            this.buttonListeleYayinevi = new System.Windows.Forms.Button();
            this.kitapTableAdapter = new NyymProject.nyymDbDataSetTableAdapters.KitapTableAdapter();
            this.buttonFavList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyymDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.isimDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.yayineviidDataGridViewTextBoxColumn,
            this.yazaridDataGridViewTextBoxColumn,
            this.resimDataGridViewImageColumn,
            this.Konu,
            this.Favori});
            this.dataGridView1.DataSource = this.kitapBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(629, 328);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // resimDataGridViewImageColumn
            // 
            this.resimDataGridViewImageColumn.DataPropertyName = "resim";
            this.resimDataGridViewImageColumn.HeaderText = "resim";
            this.resimDataGridViewImageColumn.Name = "resimDataGridViewImageColumn";
            this.resimDataGridViewImageColumn.ReadOnly = true;
            // 
            // Konu
            // 
            this.Konu.DataPropertyName = "konu";
            this.Konu.HeaderText = "Konu";
            this.Konu.Name = "Konu";
            this.Konu.ReadOnly = true;
            // 
            // Favori
            // 
            this.Favori.FillWeight = 20F;
            this.Favori.HeaderText = "Favori";
            this.Favori.Name = "Favori";
            this.Favori.ReadOnly = true;
            this.Favori.Text = "Favori";
            this.Favori.UseColumnTextForButtonValue = true;
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataMember = "Kitap";
            this.kitapBindingSource.DataSource = this.nyymDbDataSet;
            // 
            // nyymDbDataSet
            // 
            this.nyymDbDataSet.DataSetName = "nyymDbDataSet";
            this.nyymDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonListele
            // 
            this.buttonListele.Location = new System.Drawing.Point(22, 39);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(100, 23);
            this.buttonListele.TabIndex = 1;
            this.buttonListele.Text = "KategoriListele";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // comboBoxYayinevi
            // 
            this.comboBoxYayinevi.FormattingEnabled = true;
            this.comboBoxYayinevi.Location = new System.Drawing.Point(148, 12);
            this.comboBoxYayinevi.Name = "comboBoxYayinevi";
            this.comboBoxYayinevi.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYayinevi.TabIndex = 3;
            // 
            // comboBoxYazar
            // 
            this.comboBoxYazar.FormattingEnabled = true;
            this.comboBoxYazar.Location = new System.Drawing.Point(297, 12);
            this.comboBoxYazar.Name = "comboBoxYazar";
            this.comboBoxYazar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYazar.TabIndex = 4;
            // 
            // buttonListeleYazar
            // 
            this.buttonListeleYazar.Location = new System.Drawing.Point(297, 39);
            this.buttonListeleYazar.Name = "buttonListeleYazar";
            this.buttonListeleYazar.Size = new System.Drawing.Size(121, 23);
            this.buttonListeleYazar.TabIndex = 5;
            this.buttonListeleYazar.Text = "YazarListele";
            this.buttonListeleYazar.UseVisualStyleBackColor = true;
            this.buttonListeleYazar.Click += new System.EventHandler(this.buttonListeleYazar_Click);
            // 
            // buttonListeleYayinevi
            // 
            this.buttonListeleYayinevi.Location = new System.Drawing.Point(148, 39);
            this.buttonListeleYayinevi.Name = "buttonListeleYayinevi";
            this.buttonListeleYayinevi.Size = new System.Drawing.Size(121, 23);
            this.buttonListeleYayinevi.TabIndex = 6;
            this.buttonListeleYayinevi.Text = "YayineviListele";
            this.buttonListeleYayinevi.UseVisualStyleBackColor = true;
            this.buttonListeleYayinevi.Click += new System.EventHandler(this.buttonListeleYayinevi_Click);
            // 
            // kitapTableAdapter
            // 
            this.kitapTableAdapter.ClearBeforeFill = true;
            // 
            // buttonFavList
            // 
            this.buttonFavList.Location = new System.Drawing.Point(480, 39);
            this.buttonFavList.Name = "buttonFavList";
            this.buttonFavList.Size = new System.Drawing.Size(171, 23);
            this.buttonFavList.TabIndex = 7;
            this.buttonFavList.Text = "FavorilerimiListele";
            this.buttonFavList.UseVisualStyleBackColor = true;
            this.buttonFavList.Click += new System.EventHandler(this.buttonFavList_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 428);
            this.Controls.Add(this.buttonFavList);
            this.Controls.Add(this.buttonListeleYayinevi);
            this.Controls.Add(this.buttonListeleYazar);
            this.Controls.Add(this.comboBoxYazar);
            this.Controls.Add(this.comboBoxYayinevi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyymDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxYayinevi;
        private System.Windows.Forms.ComboBox comboBoxYazar;
        private System.Windows.Forms.Button buttonListeleYazar;
        private System.Windows.Forms.Button buttonListeleYayinevi;
        private nyymDbDataSet nyymDbDataSet;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private nyymDbDataSetTableAdapters.KitapTableAdapter kitapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayineviidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazaridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn resimDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Konu;
        private System.Windows.Forms.DataGridViewButtonColumn Favori;
        private System.Windows.Forms.Button buttonFavList;
    }
}