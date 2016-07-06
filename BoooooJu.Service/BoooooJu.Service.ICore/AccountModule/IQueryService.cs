using BoooooJu.Service.Core.Dal;
using BoooooJu.Service.Core.Dal.OBModels;
using BoooooJu.Service.Core.QueryParameter;
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
    public interface IQueryService
    { 
        [OperationContract]
        UserInfo FindUserInfoById(int id);
        [OperationContract]
        UserInfo FindUserInfoByAccountName(string name);
        [OperationContract]
        UserInfo FindUserInfoByEmail(string email);
        [OperationContract]
        UserInfo FindUserInfoByCellPhone(string cellPhone);
        [OperationContract]
        UserInfo FindUserInfoByOpenId(string openId);
        [OperationContract]
        KeyValuePair<Page, IEnumerable<UserInfo>> FindUserInfosByRole(Page page, int role, User_Rank rank, string nickName = null);
    }
}