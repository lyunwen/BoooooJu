using BoooooJu.Service.Core.Dal;
using BoooooJu.Service.Core.QueryParameter.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.Core.Contracts
{
    [ServiceContract]
    interface IGetUser
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
