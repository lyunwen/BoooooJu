using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.DB.Aspects.Account
{
    /// <summary>
    /// 只对数据库逻辑判断
    /// </summary>
    public interface IAccountRegister
    {
        long RegisterByMobilePhone(string phone, string password);
        long RegisterByEmail(string email, string password);
    }
    public class AccountRegister : IAccountRegister
    {
        long IAccountRegister.RegisterByEmail(string email, string password)
        {
            return 1;
        }

        long IAccountRegister.RegisterByMobilePhone(string phone, string password)
        {
            return 2;
        }
    }
}
