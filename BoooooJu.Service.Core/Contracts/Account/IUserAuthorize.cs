using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.Core.Contracts.Account
{
    public interface IUserAuthorize
    {
        bool SignInByAccountName(string accountName, string pswd);
        bool SignInByCellPhone(string cellPhone, string pswd);
        bool SignInByEmailAddress(string emailAddress, string pswd);
    }
}
