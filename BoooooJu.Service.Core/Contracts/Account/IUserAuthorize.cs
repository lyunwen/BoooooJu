using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.Core.Contracts.Account
{
    [ServiceContract]
    public interface IUserAuthorize
    {
        [OperationContract]
        bool SignInByAccountName(string accountName, string pswd);
        [OperationContract]
        bool SignInByCellPhone(string cellPhone, string pswd);
        [OperationContract]
        bool SignInByEmailAddress(string emailAddress, string pswd);
    }
}
