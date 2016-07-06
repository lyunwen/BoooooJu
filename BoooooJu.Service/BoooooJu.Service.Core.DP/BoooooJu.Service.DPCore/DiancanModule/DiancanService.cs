using BoooooJu.Service.Core.Dal.OBModels;
using BoooooJu.Service.Core.Dal.Rank;
using BoooooJu.Service.Core.QueryParameter;
using BoooooJu.Service.DPModels; 
using BoooooJu.Service.ICore.DiancanModule;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BoooooJu.Service.DPCore.Diancan
{
    public class DiancanService : IDiancanService
    {
        public DC_User AddUser(DC_User user)
        {
            DC_User result = null;
            StringBuilder sqlCmdTextSb = new StringBuilder();
            sqlCmdTextSb.Append("INSERT [DC_User]");
            sqlCmdTextSb.Append(@" (Name,PCAddress,Password) OUTPUT INSERTED.Id");
            sqlCmdTextSb.Append(@" VALUES ");
            sqlCmdTextSb.Append(@" (@Name,@PCAddress,@Password)");
            try
            {
                result = Base.BaseAction<DC_User>.Insert(sqlCmdTextSb.ToString(), user, "DC_User");
            }
            catch
            {
                return null;
            }
            return result;
        }
        public bool DeleteOrderById(int orderId)
        {
            bool result = false;
            StringBuilder sqlCmdText = new StringBuilder();
            sqlCmdText.AppendFormat("DELETE [{0}] WHERE Id=@Id", @"User");
            try
            {
                using (IDbConnection conn = DBHelper.OpenConnection())
                {
                    result = conn.Execute(sqlCmdText.ToString(), orderId) > 0;
                }
            }
            catch
            {
                return false;
            }
            return result;
        }

        public IEnumerable<DC_Food> FindEnableFoods()
        {
            IEnumerable<DC_Food> result = null;
            string sqlCmdText = @"SELECT * FROM [DC_Food] WHERE Enable=1";
            using (var conn = DBHelper.OpenConnection())
            {
                result = conn.Query<DC_Food>(sqlCmdText);
            }
            return result;
        }

        public IEnumerable<DC_User> FindUsersByIp(string ip)
        {
            IEnumerable<DC_User> result = null;
            string sqlCmdText = @"SELECT * FROM [DC_User] WHERE PCAddress=@PCAddress";
            using (var conn = DBHelper.OpenConnection())
            {
                result = conn.Query<DC_User>(sqlCmdText, new { PCAddress = ip });
            }
            return result;
        }

        public DC_User FindUserByName(string name)
        {
            DC_User result = null;
            using (var conn = DBHelper.OpenConnection())
            {
                string sqlCmdText = @"SELECT * FROM [DC_User] WHERE Name=@Name";
                var foo = conn.Query(sqlCmdText, new { Name = name });
                if (null != foo)
                {
                    result = foo.FirstOrDefault();
                }
            }
            return result;
        }

        public KeyValuePair<Page, List<OBDC_Order>> GetOrders(Page page, DC_OBOrder_Rank rank)
        {
            KeyValuePair<Page, List<OBDC_Order>> result = new KeyValuePair<Page, List<OBDC_Order>>();
            if (page == null)
                return result;
            using (var conn = DBHelper.OpenConnection())
            {
                var t = conn.Query("[dbo].[Proc_Page]", new { Tables = "DC_Order  LEFT JOIN DC_Food ON DC_Food.Id=DC_Order.FoodId", Returns = "DC_Food.Name,DC_Food.Id as FoodId,DC_Order.Id AS OrderId", OrderBy = "DC_Food.Id asc" }, null, true, null, CommandType.StoredProcedure);
            }
            return result;
        }

        public DC_Order GetTodayOrder(int userId)
        {
            throw new NotImplementedException();
        }

        public DC_Order PlaceOrder(DC_Order order)
        {
            throw new NotImplementedException();
        }

        public DC_Order UpdateOrder(DC_Order order)
        {
            throw new NotImplementedException();
        }

        public DC_User UpdateUser(DC_User user)
        {
            throw new NotImplementedException();
        }

        public bool CancelOrder(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}
