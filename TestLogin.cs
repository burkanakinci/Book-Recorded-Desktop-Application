using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyymProject
{
    class TestLogin
    {

        public static string mail, sifre, dTAdminYetki_id;
        //LoginProcess lP = new LoginProcess();
        public bool TestMS()
        {
            if (LoginScreen.txtBoxMail1.Text.ToString()!=mail|| 
                LoginScreen.txtBoxSifre1.Text!=sifre)
            {

                return false;
            }
            MessageBox.Show(" Giriş başarılı ");
            return true;
        }
        public bool TestMSAdmin()
        {
            if((LoginScreen.testMail1!=mail || LoginScreen.testSifre1!=sifre) 
                && dTAdminYetki_id=="1")
            {

                MessageBox.Show(" Mail veya sifre hatalı admin girişi yapıldı ");
                return false;
            }

            if(LoginScreen.testMail1==mail && LoginScreen.testSifre1==sifre && 
                dTAdminYetki_id!="1")
            {

                MessageBox.Show(" Kullanıcı yetkili kullanıcı Admin girişi yaptı ");
                return false;
            }

            return true;
        }
    }
}
