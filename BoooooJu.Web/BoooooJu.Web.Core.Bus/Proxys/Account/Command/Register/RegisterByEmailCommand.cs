using BoooooJu.Web.Core.Bus.Proxys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.Bus.Clients.Account.Command.Register
{
    public class RegisterByEmailCommand : ICommand
    {
        public RegisterByEmailCommand(string email, string password, string fromType = null)
        {
            this.Email = email;
            this.Password = password;
            this.FromType = fromType;
        }
        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string Email { get; private set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string Password { get; private set; }
        /// <summary>
        /// 注册来源标识
        /// </summary>
        public string FromType { get; private set; }
    }
}
