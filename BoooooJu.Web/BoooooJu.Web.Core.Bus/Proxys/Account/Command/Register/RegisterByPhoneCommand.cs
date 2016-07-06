using BoooooJu.Web.Core.Bus.Proxys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.Bus.Clients.Account.Command.Register
{
    public class RegisterByPhoneCommand : ICommand
    {
        public RegisterByPhoneCommand(string mobilePhone, string password,string fromType=null)
        {
            this.MobilePhone = mobilePhone;
            this.Password = password;
            this.FromType = fromType;
        }
        public string MobilePhone { get; private set; }
        public string Password { get; private set; }
        public string FromType { get; private set; }
    }
}
