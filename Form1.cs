using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NyymProject
{

    public partial class LoginScreen : Form
    {

        

        public LoginScreen()
        {
            InitializeComponent();
        }

        SqlConnection connectionNyymAdmin = new SqlConnection(@"Data Source=DESKTOP-3625S7R;Initial Catalog=nyymDb;Integrated Security=True");

        public static TextBox txtBoxMail1 = new TextBox();
        public static TextBox txtBoxSifre1 = new TextBox();
        public static TextBox txtBoxSifreYeni = new TextBox();

        public static string testMail1, testSifre1;

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            txtBoxMail1.Text = textBoxMail.Text.Trim();
            txtBoxSifre1.Text = textBoxSifre.Text.Trim();

            LoginProcess logProcess1 = new LoginProcess();

            ICommand login1 = new Login(logProcess1);
            ICommand updatePassword1 = new UpdatePassword(logProcess1);
            
            Processes process = new Processes(login1,updatePassword1);

            process.ClickLoginForm();


            TestLogin testLogin = new TestLogin();
            testLogin.TestMS();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtBoxMail1.Text = textBoxMail2.Text.Trim();
            txtBoxSifre1.Text = textBoxOldPassword.Text.Trim();
            txtBoxSifreYeni.Text = textBoxNewPassword.Text.Trim();

            LoginProcess logProcess1 = new LoginProcess();

            ICommand login1 = new Login(logProcess1);
            ICommand updatePassword1 = new UpdatePassword(logProcess1);

            Processes process = new Processes(login1, updatePassword1);

            process.ClickUpdatePassword();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonKayit_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("INSERT INTO Kullanici " +
                "VALUES (@isim,@mail,@yetki_id,@sifre,@telefon)", connectionNyymAdmin);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@isim", textBoxKayitIsim.Text);
            cmd.Parameters.AddWithValue("@mail", textBoxKayitMail.Text);
            cmd.Parameters.AddWithValue("@yetki_id", 2);
            cmd.Parameters.AddWithValue("@sifre", textBoxKayitSifre.Text);
            cmd.Parameters.AddWithValue("@telefon", textBoxKayitTelefon.Text);

            try
            {
                connectionNyymAdmin.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("veritabani bağlantisi açik");
            }

            cmd.ExecuteNonQuery();
            connectionNyymAdmin.Close();
        }

        private void adminPanelButton_Click(object sender, EventArgs e)
        {
            //AdminPanel Giriş butonu
            try
            {
                connectionNyymAdmin.Open();
            }
            catch (Exception)
            {

                MessageBox.Show(connectionNyymAdmin.State.ToString());
            }



            string sql = "Select * from Kullanici where mail=@Mail And sifre=@Sifre";

            SqlParameter prmMail = new SqlParameter("Mail", textBoxMail.Text.Trim());
            SqlParameter prmSifre = new SqlParameter("Sifre", textBoxSifre.Text.Trim());

            SqlCommand komut = new SqlCommand(sql, connectionNyymAdmin);

            komut.Parameters.Add(prmMail);
            komut.Parameters.Add(prmSifre);

            DataTable dTAdmin = new DataTable();

            SqlDataAdapter dA = new SqlDataAdapter(komut);

            testMail1 = textBoxMail.Text.ToString().Trim();
            testSifre1 = textBoxSifre.Text.ToString().Trim();

            dA.Fill(dTAdmin);
            if (dTAdmin.Rows.Count > 0 && dTAdmin.Rows[0][3].ToString() == "1")
            {

                TestLogin.mail = dTAdmin.Rows[0][2].ToString();
                TestLogin.sifre = dTAdmin.Rows[0][4].ToString();
                TestLogin.dTAdminYetki_id = dTAdmin.Rows[0][3].ToString();

                Form4 frm4 = new Form4();
                frm4.Show();
                //MessageBox.Show("Başarılı admin girişi    ");

            }
            //else
            //{

            //    MessageBox.Show("Admin girişi hatalı");
            //}
        }
    }
}
