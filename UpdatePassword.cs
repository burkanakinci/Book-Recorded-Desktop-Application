using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyymProject
{
    class UpdatePassword : ICommand
    {

        private LoginProcess loginProcess;

        public UpdatePassword(LoginProcess log)
        {

            loginProcess = log;
        }

        public void Execute()
        {

            loginProcess.UpdatePassword();
        }
    }
}
