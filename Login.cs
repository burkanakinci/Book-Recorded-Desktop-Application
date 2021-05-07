using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyymProject
{
   public class Login : ICommand
    {

        private LoginProcess loginProcess;

        public Login(LoginProcess log)
        {

            loginProcess = log;
        }

        public void Execute()
        {

            loginProcess.LoginForm();
        }

        
    }
}
