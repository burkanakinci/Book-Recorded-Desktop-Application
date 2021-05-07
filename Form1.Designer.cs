namespace NyymProject
{
    partial class LoginScreen
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.textBoxMail2 = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonUpdatePassword = new System.Windows.Forms.Button();
            this.adminPanelButton = new System.Windows.Forms.Button();
            this.nyymDbDataSet1 = new NyymProject.nyymDbDataSet();
            this.nyymDbDataSet2 = new NyymProject.nyymDbDataSet();
            this.buttonKayit = new System.Windows.Forms.Button();
            this.textBoxKayitMail = new System.Windows.Forms.TextBox();
            this.textBoxKayitIsim = new System.Windows.Forms.TextBox();
            this.textBoxKayitTelefon = new System.Windows.Forms.TextBox();
            this.textBoxKayitSifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nyymDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyymDbDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Black;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogin.Location = new System.Drawing.Point(306, 81);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(152, 33);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Giriş Yap";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(306, 16);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(152, 20);
            this.textBoxMail.TabIndex = 1;
            this.textBoxMail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(229, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mail : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(229, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre : ";
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(306, 55);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(152, 20);
            this.textBoxSifre.TabIndex = 5;
            this.textBoxSifre.TextChanged += new System.EventHandler(this.textBoxSifre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(469, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mail : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(469, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Eski Şifre : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(531, 55);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.Size = new System.Drawing.Size(160, 20);
            this.textBoxOldPassword.TabIndex = 9;
            this.textBoxOldPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBoxMail2
            // 
            this.textBoxMail2.Location = new System.Drawing.Point(531, 16);
            this.textBoxMail2.Name = "textBoxMail2";
            this.textBoxMail2.Size = new System.Drawing.Size(160, 20);
            this.textBoxMail2.TabIndex = 8;
            this.textBoxMail2.Text = " ";
            this.textBoxMail2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(531, 89);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(160, 20);
            this.textBoxNewPassword.TabIndex = 11;
            this.textBoxNewPassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(469, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Yeni Şifre : ";
            // 
            // buttonUpdatePassword
            // 
            this.buttonUpdatePassword.BackColor = System.Drawing.Color.Black;
            this.buttonUpdatePassword.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUpdatePassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUpdatePassword.Location = new System.Drawing.Point(539, 126);
            this.buttonUpdatePassword.Name = "buttonUpdatePassword";
            this.buttonUpdatePassword.Size = new System.Drawing.Size(152, 33);
            this.buttonUpdatePassword.TabIndex = 12;
            this.buttonUpdatePassword.Text = "Şifreyi Güncelle";
            this.buttonUpdatePassword.UseVisualStyleBackColor = false;
            this.buttonUpdatePassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminPanelButton
            // 
            this.adminPanelButton.BackColor = System.Drawing.Color.Black;
            this.adminPanelButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminPanelButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminPanelButton.Location = new System.Drawing.Point(306, 145);
            this.adminPanelButton.Name = "adminPanelButton";
            this.adminPanelButton.Size = new System.Drawing.Size(152, 33);
            this.adminPanelButton.TabIndex = 13;
            this.adminPanelButton.Text = "AdminGirişi";
            this.adminPanelButton.UseVisualStyleBackColor = false;
            this.adminPanelButton.Click += new System.EventHandler(this.adminPanelButton_Click);
            // 
            // nyymDbDataSet1
            // 
            this.nyymDbDataSet1.DataSetName = "nyymDbDataSet";
            this.nyymDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nyymDbDataSet2
            // 
            this.nyymDbDataSet2.DataSetName = "nyymDbDataSet";
            this.nyymDbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonKayit
            // 
            this.buttonKayit.BackColor = System.Drawing.Color.Black;
            this.buttonKayit.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKayit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonKayit.Location = new System.Drawing.Point(233, 262);
            this.buttonKayit.Name = "buttonKayit";
            this.buttonKayit.Size = new System.Drawing.Size(152, 33);
            this.buttonKayit.TabIndex = 14;
            this.buttonKayit.Text = "KayıtOl";
            this.buttonKayit.UseVisualStyleBackColor = false;
            this.buttonKayit.Click += new System.EventHandler(this.buttonKayit_Click);
            // 
            // textBoxKayitMail
            // 
            this.textBoxKayitMail.Location = new System.Drawing.Point(471, 304);
            this.textBoxKayitMail.Name = "textBoxKayitMail";
            this.textBoxKayitMail.Size = new System.Drawing.Size(220, 20);
            this.textBoxKayitMail.TabIndex = 16;
            // 
            // textBoxKayitIsim
            // 
            this.textBoxKayitIsim.Location = new System.Drawing.Point(471, 260);
            this.textBoxKayitIsim.Name = "textBoxKayitIsim";
            this.textBoxKayitIsim.Size = new System.Drawing.Size(220, 20);
            this.textBoxKayitIsim.TabIndex = 15;
            // 
            // textBoxKayitTelefon
            // 
            this.textBoxKayitTelefon.Location = new System.Drawing.Point(471, 401);
            this.textBoxKayitTelefon.Name = "textBoxKayitTelefon";
            this.textBoxKayitTelefon.Size = new System.Drawing.Size(220, 20);
            this.textBoxKayitTelefon.TabIndex = 18;
            // 
            // textBoxKayitSifre
            // 
            this.textBoxKayitSifre.Location = new System.Drawing.Point(471, 355);
            this.textBoxKayitSifre.Name = "textBoxKayitSifre";
            this.textBoxKayitSifre.Size = new System.Drawing.Size(220, 20);
            this.textBoxKayitSifre.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(401, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "İsim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(402, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlText;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(396, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Sifre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlText;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(375, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Telefon";
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(705, 464);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxKayitTelefon);
            this.Controls.Add(this.textBoxKayitSifre);
            this.Controls.Add(this.textBoxKayitMail);
            this.Controls.Add(this.textBoxKayitIsim);
            this.Controls.Add(this.buttonKayit);
            this.Controls.Add(this.adminPanelButton);
            this.Controls.Add(this.buttonUpdatePassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxOldPassword);
            this.Controls.Add(this.textBoxMail2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.buttonLogin);
            this.Name = "LoginScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nyymDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyymDbDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.TextBox textBoxMail2;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonUpdatePassword;
        public  System.Windows.Forms.TextBox textBoxMail;
        public  System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Button adminPanelButton;
        private nyymDbDataSet nyymDbDataSet1;
        private nyymDbDataSet nyymDbDataSet2;
        private System.Windows.Forms.Button buttonKayit;
        public System.Windows.Forms.TextBox textBoxKayitMail;
        public System.Windows.Forms.TextBox textBoxKayitIsim;
        public System.Windows.Forms.TextBox textBoxKayitTelefon;
        public System.Windows.Forms.TextBox textBoxKayitSifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

