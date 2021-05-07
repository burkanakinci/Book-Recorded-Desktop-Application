using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace NyymProject
{
    public class LoginProcess 
    {
        public static string dTMail, dTSifre;
        public static int favoriKulI;
        SqlConnection connectionNyym = new SqlConnection(@"Data Source=DESKTOP-3625S7R;
            Initial Catalog=nyymDb;Integrated Security=True");

        public void LoginForm()
        {

            connectionNyym.Open();

                
                string sql = "Select * from Kullanici where mail=@Mail And sifre=@Sifre";

                SqlParameter prmMail = new SqlParameter("Mail", LoginScreen.txtBoxMail1.Text);
                SqlParameter prmSifre = new SqlParameter("Sifre", LoginScreen.txtBoxSifre1.Text);

                SqlCommand komut = new SqlCommand(sql, connectionNyym);

                komut.Parameters.Add(prmMail);
                komut.Parameters.Add(prmSifre);

                DataTable dT = new DataTable();

                SqlDataAdapter dA = new SqlDataAdapter(komut);

                dA.Fill(dT);
                if (dT.Rows.Count > 0)
                {

                favoriKulI = (int)dT.Rows[0][0];

                    TestLogin.mail= dT.Rows[0][2].ToString();
                    TestLogin.sifre = dT.Rows[0][4].ToString();

                    Form2 frm2 = new Form2();
                    frm2.Show();
                }
                //else
                //{

                //    MessageBox.Show("Hatalı Giriş Yapildi");
                //}
        }

        public void UpdatePassword()
        {

            connectionNyym.Open();


            string sql = "Select * from Kullanici where mail=@Mail And sifre=@Sifre";

            SqlParameter prmMail = new SqlParameter("Mail", LoginScreen.txtBoxMail1.Text);
            SqlParameter prmSifre = new SqlParameter("Sifre", LoginScreen.txtBoxSifre1.Text);

            SqlCommand komut = new SqlCommand(sql, connectionNyym);

            komut.Parameters.Add(prmMail);
            komut.Parameters.Add(prmSifre);

            DataTable dT = new DataTable();

            SqlDataAdapter dA = new SqlDataAdapter(komut);

            dA.Fill(dT);

            if (dT.Rows.Count > 0)
            {

                SqlCommand komut1 = new SqlCommand("update Kullanici set sifre='"+
                LoginScreen.txtBoxSifreYeni.Text.Trim().ToString()+"'where mail='"+
                LoginScreen.txtBoxMail1.Text.Trim().ToString()+"'",connectionNyym);

                komut1.ExecuteNonQuery();

                connectionNyym.Close();

                MessageBox.Show("şifre başarıyla güncellendi");

            }
            else
            {

                MessageBox.Show("Mail ve Şifre uyuşmuyor");
            }
        }
    }
}
