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
    public interface IAccountRegister
    {
        int RegisterByMobilePhone(string phone, string password, string fromType = null);
        int RegisterByEmail(string email, string password, string fromType = null);
        int ResgiterByUserName(string userName, string password, string fromType = null);
    }
    public class AccountRegister : IAccountRegister
    {
        int IAccountRegister.RegisterByEmail(string email, string password, string fromType)
        {
            User user = new User
            {
                Role = 1,
                NickName = "",
                UserName = null,
                Email = email,
                MobilePhone = null,
                OpenId = null,
                Password = password,
                CreateTime = DateTime.Now,
                LastLoginTime = DateTime.Now,
                Sex = Dal.DBModels.CommonEnum.SexEnum.Unknown
            };
            string sqlCmd = @"INSERT INTO [User] ([Role],NickName,UserName,Email,MobilePhone,OpenId,[Password],CreateTime,LastLoginTime,Sex) VALUES(@Role,@NickName,@UserName,@Email,@MobilePhone,@OpenId,@Password,@CreateTime,@LastLoginTime,@Sex)";
            using (var conn = CommandDBHelper.OpenConnection())
            {
                return conn.Execute(sqlCmd, user);
            }
        }

        int IAccountRegister.RegisterByMobilePhone(string phone, string password, string fromType)
        {
            User user = new User
            {
                Role = 1,
                NickName = "",
                UserName = null,
                Email = null,
                MobilePhone = phone,
                OpenId = null,
                Password = password,
                CreateTime = DateTime.Now,
                LastLoginTime = DateTime.Now,
                Sex = Dal.DBModels.CommonEnum.SexEnum.Unknown
            };
            string sqlCmd = @"INSERT INTO [User] ([Role],NickName,UserName,Email,MobilePhone,OpenId,[Password],CreateTime,LastLoginTime,Sex) VALUES(@Role,@NickName,@UserName,@Email,@MobilePhone,@OpenId,@Password,@CreateTime,@LastLoginTime,@Sex)";

            using (var conn = CommandDBHelper.OpenConnection())
            {
                return conn.Execute(sqlCmd, user);
            }
        }

        int IAccountRegister.ResgiterByUserName(string userName, string password, string fromType)
        {
            User user = new User
            {
                Role = 1,
                NickName = "",
                UserName = userName,
                Email = null,
                MobilePhone = null,
                OpenId = null,
                Password = password,
                CreateTime = DateTime.Now,
                LastLoginTime = DateTime.Now,
                Sex = Dal.DBModels.CommonEnum.SexEnum.Unknown
            };
            string sqlCmd = @"INSERT INTO [User] ([Role],NickName,UserName,Email,MobilePhone,OpenId,[Password],CreateTime,LastLoginTime,Sex) VALUES(@Role,@NickName,@UserName,@Email,@MobilePhone,@OpenId,@Password,@CreateTime,@LastLoginTime,@Sex)";

            using (var conn = CommandDBHelper.OpenConnection())
            {
                return conn.Execute(sqlCmd, user);
            }
        }
    }
}
