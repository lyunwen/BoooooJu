using BoooooJu.Service.Core.Dal;
using BoooooJu.Service.DPModels;
using BoooooJu.Service.DPModels.OBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.ICore.AccountModule
{
    [ServiceContract]
    public interface IRegisterService
    {
        [OperationContract]
        UserInfo RegisterByAccountName(User user, string accountName, string pswd);
        [OperationContract]
        UserInfo RegisterByCellPhone(User user, string cellPhone, string pswd);
        [OperationContract]
        UserInfo RegisterByEmailAddress(User user, string emailAddress, string pwsd);
        [OperationContract]
        UserInfo RegisterByOpneId(User user, string opneId);
    }
}
