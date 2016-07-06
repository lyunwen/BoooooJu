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
    public interface IUpdateService
    {
        [OperationContract]
        UserInfo AlterPswdByAccountName(string accountName, string pswd);
        [OperationContract]
        UserInfo AlterPswdByCellPhone(string cellPhone, string pswd);
        [OperationContract]
        UserInfo AlterPswdByEmailAddress(string emailAddress, string pswd);
        [OperationContract]
        UserInfo AlterPswdById(int userId, string pswd);
        [OperationContract]
        UserInfo AlterPswdByOpenId(string openId, string pswd);
    }
}