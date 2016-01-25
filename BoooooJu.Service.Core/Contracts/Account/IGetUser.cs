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
        User GetUserById(int id);
        [OperationContract]
        User GetUserByAccount(string accountName);
        [OperationContract]
        User GetUserByCellPhone(string cellPhone);
        [OperationContract]
        List<User> GetUsers(IPage page);
    }
}
