using BoooooJu.Service.Core.Contracts.Base;
using BoooooJu.Service.Core.Dal;
using System.ServiceModel;

namespace BoooooJu.Service.Core.Contracts.Account
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract]
    public interface ISetUser : IBaseSetData<User>
    {
        #region 用户注册
        [OperationContract]
        User RegisterByAccountName(User user, string accountName,string pswd);
        [OperationContract]
        User RegisterByCellPhone(User user, string cellPhone,string pswd);
        [OperationContract]
        User RegisterByEmailAddress(User user, string emailAddress,string pwsd);
        [OperationContract]
        User RegisterByOpneId(User user, string opneId);
        #endregion

        #region 修改密码
        [OperationContract]
        User AlterPswdByAccountName(string accountName, string pswd);
        [OperationContract]
        User AlterPswdByCellPhone(string cellPhone, string pswd);
        [OperationContract]
        User AlterPswdByEmailAddress(string emailAddress, string pswd);
        [OperationContract]
        User AlterPswdByOpenId(string openId, string pswd);
        #endregion
    }
}
