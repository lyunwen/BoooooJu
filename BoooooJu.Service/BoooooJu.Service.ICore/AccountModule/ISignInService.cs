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
    public interface ISignInService
    {
        [OperationContract]
        UserInfo SignInById(int userId, string token); 
        #region
        [OperationContract]
        string GetTokenByAccountName(string accountName, string pswd);
        [OperationContract]
        string GetTokenByCellPhone(string cellPhone, string pswd);
        [OperationContract]
        string GetTokenByEmaiAddress(string emailAddresss, string pswd);
        [OperationContract]
        string GetTokenByOpenId(string openId, string pswd);
        #endregion
    }
}
