using BoooooJu.Service.Core.Dal;
using BoooooJu.Service.Core.QueryParameter.Base;
using System.Collections.Generic;
using System.ServiceModel;

namespace BoooooJu.Service.Core.Contracts.Account
{
    [ServiceContract]
    interface IGetUser : Base.IBaseGetData<User>
    {
        [OperationContract]
        User GetUserByAccount(string accountName);
        [OperationContract]
        User GetUserByCellPhone(string cellPhone);
        [OperationContract]
        List<User> GetUsers(IPage page);

        #region 登入
        [OperationContract]
        User SignByAccountName(string accountName, string pswd);
        [OperationContract]
        User SignByCellPhone(string cellPhone, string pswd);
        [OperationContract]
        User SignByEmaiAddress(string emailAddresss, string pswd);
        [OperationContract]
        User SignByOpenId(string openId, string pswd);
        #endregion
    }
}
