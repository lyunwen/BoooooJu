using BoooooJu.Web.Core.Dal.DBModels;
using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BoooooJu.Web.Core.DB.Aspects.Account
{
    /// <summary>
    /// 只对数据库逻辑判断
    /// </summary>
    public interface IAccountRecord
    {
        int User_loginRecordInsert(long userId, DateTime loginTime, string ip, string equipment);
    }
    public class AccountRecord : IAccountRecord
    {  
        int IAccountRecord.User_loginRecordInsert(long userId, DateTime loginTime, string ip, string equipment)
        {
            User_LoginRecord record = new User_LoginRecord
            {
                UserId = userId,
                Equipment = equipment,
                LoginIp = ip,
                LoginTime = loginTime
            };
            string sqlCmd = @"INSERT User_LoginRecord(UserId,LoginTime,LoginIp,Equipment) VALUES(@UserId,@LoginTime,@LoginIp,@Equipment)";
            using (var conn = CommandDBHelper.OpenConnection())
            {
                return conn.Execute(sqlCmd, record);
            }
        }
    }
}