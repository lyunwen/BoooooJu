using BoooooJu.Service.Core.Contracts.Base;
using BoooooJu.Service.Core.Dal.OBModels;
using BoooooJu.Service.Core.Dal.Rank;
using BoooooJu.Service.Core.QueryParameter;
using BoooooJu.Service.DPModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.ICore.DiancanModule
{
    [ServiceContract]
    public interface IDiancanService
    {
        #region user
        [OperationContract]
        DC_User AddUser(DC_User user);

        [OperationContract]
        DC_User UpdateUser(DC_User user);
        [OperationContract]
        DC_User FindUserByName(string name);
        [OperationContract]
        IEnumerable<DC_User> FindUsersByIp(string ip);
        #endregion

        #region order 
        [OperationContract]
        DC_Order PlaceOrder(DC_Order order);

        [OperationContract]
        bool DeleteOrderById(int orderId);

        [OperationContract]
        DC_Order UpdateOrder(DC_Order order);
        [OperationContract]
        DC_Order GetTodayOrder(int userId);

        [OperationContract]
        KeyValuePair<Page, List<OBDC_Order>> GetOrders(Page page, DC_OBOrder_Rank rank);
         

        #endregion

        #region food
        [OperationContract]
        IEnumerable<DC_Food> FindEnableFoods();
        #endregion
    }
}
