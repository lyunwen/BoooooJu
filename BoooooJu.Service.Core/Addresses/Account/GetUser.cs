using BoooooJu.Service.Core.Contracts;
using BoooooJu.Service.Core.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoooooJu.Service.Core.QueryParameter.Base;
using BoooooJu.Service.Core.Contracts.Account;

namespace BoooooJu.Service.Core.Addresses.Account
{
    public class GetUser : Base.BaseGetData<User>, IGetUser
    {
        User IGetUser.GetUserByAccount(string accountName)
        {
            Dal.User user = null;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                user = db.Users.FirstOrDefault(x => x.Account == accountName);
            }
            //User user = new User
            //{
            //    Account = accountName,
            //    CellPhone = "13058171032",
            //    CellPhoneValidate = false,
            //    NickName = "zaizaiyou"+new Random().Next(100,999),
            //    Signature = "世界这么大",
            //    EmailValidate = false,
            //    Password = "123456",
            //    PasswordSalt = "0",
            //    PasswordSaltType = 0,
            //    Sex = 2
            //};
            return user;
        }

        User IGetUser.GetUserByCellPhone(string cellPhone)
        {
            Dal.User user = null;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                user = db.Users.First(x => x.CellPhone == cellPhone);
            }
            return user;
        }

        User IGetUser.GetUserById(int id)
        {
            Dal.User user = null;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                user = db.Users.First(x => x.Id == id);
            }
            return user;
        }

        List<User> IGetUser.GetUsers(IPage page)
        {
            List<Dal.User> users = null;
            if (page == null)
                return users;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                users = db.Users.Take((page.PageIndex - 1) * page.PageSize).Skip(page.PageSize).ToList();
            }
            return users;
        }

        #region 登入
        public User SignByAccountName(string accountName, string pswd)
        {
            User user = null;
            if (accountName == null || pswd == null)
                return user;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                var foo = db.Users.FirstOrDefault(x => x.Account == accountName);
                if (foo != null)
                {
                    var bar = db.UserKeys.FirstOrDefault(x => x.Pswd == pswd);
                    if (bar != null)
                    {
                        user = foo;
                    }
                }
            }
            return user;
        }

        public User SignByCellPhone(string cellPhone, string pswd)
        {
            User user = null;
            if (cellPhone == null || pswd == null)
                return user;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                var foo = db.Users.FirstOrDefault(x => x.CellPhoneValidate && x.CellPhone == cellPhone);
                if (foo != null)
                {
                    var bar = db.UserKeys.FirstOrDefault(x => x.Pswd == pswd);
                    if (bar != null)
                    {
                        user = foo;
                    }
                }
            }
            return user;
        }

        public User SignByEmaiAddress(string emailAddresss, string pswd)
        {
            User user = null;
            if (emailAddresss == null || pswd == null)
                return user;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                var foo = db.Users.FirstOrDefault(x => x.EmailValidate && x.EmailAdress == emailAddresss);
                if (foo != null)
                {
                    var bar = db.UserKeys.FirstOrDefault(x => x.Pswd == pswd);
                    if (bar != null)
                    {
                        user = foo;
                    }
                }
            }
            return user;
        }
        #endregion
    }
}
