using BoooooJu.Service.Api.Dal.DBModels;
using BoooooJu.Web.Core.DB;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.Api.Dal.Aspects.User
{
    public interface IUserRecord
    {
        int User_loginRecordInsert(long userId, DateTime loginTime, string ip, string equipment);
    }
    public class UserRecord : IUserRecord
    { 
        int IUserRecord.User_loginRecordInsert(long userId, DateTime loginTime, string ip, string equipment)
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
