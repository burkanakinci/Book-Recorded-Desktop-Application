using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyymProject
{
    class Processes
    {

        private ICommand loginFormCommand;
        private ICommand updatePasswordCommand;

        public Processes(ICommand log , ICommand update)
        {

            this.loginFormCommand = log;
            this.updatePasswordCommand = update;
        }

        public void ClickLoginForm()
        {

            loginFormCommand.Execute();
        }

        public void ClickUpdatePassword()
        {

            updatePasswordCommand.Execute();
        }
    }
}
