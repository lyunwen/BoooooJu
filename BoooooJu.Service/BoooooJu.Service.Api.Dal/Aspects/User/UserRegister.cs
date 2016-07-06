using BoooooJu.Web.Core.DB;
using BoooooJu.Service.Api.Dal.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace BoooooJu.Service.Api.Dal.Aspects.User
{
    public interface IUserRegister
    {
        int RegisterByMobilePhone(string phone, string password, string fromType = null);
        int RegisterByEmail(string email, string password, string fromType = null);
        int ResgiterByUserName(ResgiterByUserNameCommand command);
    }
    public class UserRegister : IUserRegister
    {
        int IUserRegister.RegisterByEmail(string email, string password, string fromType)
        {
            DBModels.User user = new DBModels.User
            {
                Role = 1,
                NickName = "",
                UserName = null,
                Email = email,
                MobilePhone = null,
                OpenId = null,
                Password = password,
                CreateTime = DateTime.Now,
                LastLoginTime = DateTime.Now
            };
            string sqlCmd = @"INSERT INTO [User] ([Role],NickName,UserName,Email,MobilePhone,OpenId,[Password],CreateTime,LastLoginTime,Sex) VALUES(@Role,@NickName,@UserName,@Email,@MobilePhone,@OpenId,@Password,@CreateTime,@LastLoginTime,@Sex)";
            using (var conn = CommandDBHelper.OpenConnection())
            {
                return conn.Execute(sqlCmd, user);
            }
        }

        int IUserRegister.RegisterByMobilePhone(string phone, string password, string fromType)
        {
            DBModels.User user = new DBModels.User
            {
                Role = 1,
                NickName = "",
                UserName = null,
                Email = null,
                MobilePhone = phone,
                OpenId = null,
                Password = password,
                CreateTime = DateTime.Now,
                LastLoginTime = DateTime.Now
            };
            string sqlCmd = @"INSERT INTO [User] ([Role],NickName,UserName,Email,MobilePhone,OpenId,[Password],CreateTime,LastLoginTime,Sex) VALUES(@Role,@NickName,@UserName,@Email,@MobilePhone,@OpenId,@Password,@CreateTime,@LastLoginTime,@Sex)";

            using (var conn = CommandDBHelper.OpenConnection())
            {
                return conn.Execute(sqlCmd, user);
            }
        }

        int IUserRegister.ResgiterByUserName(ResgiterByUserNameCommand command)
        {
            DBModels.User user = new DBModels.User
            {
                Role = 1,
                NickName = "",
                UserName = command.UserName,
                Email = null,
                MobilePhone = null,
                OpenId = null,
                Sex = SexEnum.UnKown,
                Password = command.password,
                CreateTime = DateTime.Now,
                LastLoginTime = DateTime.Now
            };
            string sqlCmd = @"INSERT INTO [User] ([Role],NickName,UserName,Email,MobilePhone,OpenId,[Password],CreateTime,LastLoginTime,Sex) VALUES(@Role,@NickName,@UserName,@Email,@MobilePhone,@OpenId,@Password,@CreateTime,@LastLoginTime,@Sex)";

            using (var conn = CommandDBHelper.OpenConnection())
            {
                return conn.Execute(sqlCmd, user);
            }
        }
    }
    #region Command
    public class ResgiterByUserNameCommand
    {
        public string UserName { get; set; }
        public string password { get; set; }
        public string fromType { get; set; }
    }
    #endregion
}
