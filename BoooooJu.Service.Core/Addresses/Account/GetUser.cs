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
            User user = null;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                UserKey key = db.UserKeys.FirstOrDefault(x =>x.AccountNameValidate&&x.AccountName == accountName);
                if (key != null)
                {
                    user = db.Users.FirstOrDefault(x => x.Id == key.UserId);
                }
            }
            return user;
        }

        User IGetUser.GetUserByCellPhone(string cellPhone)
        {
            User user = null;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                UserKey key = db.UserKeys.FirstOrDefault(x => x.CellPhoneValidate && x.CellPhone == cellPhone);
                if (key != null)
                {
                    user = db.Users.FirstOrDefault(x => x.Id == key.UserId);
                }
            }
            return user;
        }

        User IGetUser.GetUserById(int id)
        {
            User user = null;
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
         User IGetUser.SignByAccountName(string accountName, string pswd)
        {
            User user = null;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                var foo = db.UserKeys.FirstOrDefault(x => x.AccountNameValidate&&x.AccountName == accountName&&x.Pswd==pswd);
                if (foo != null)
                {
                    var bar = db.Users.FirstOrDefault(x => x.Id == foo.UserId);
                    if (bar != null)
                    {
                        user = bar;
                    }
                }
            }
            return user;
        }

         User IGetUser.SignByCellPhone(string cellPhone, string pswd)
        {
            User user = null;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                var foo = db.UserKeys.FirstOrDefault(x => x.CellPhoneValidate && x.CellPhone == cellPhone && x.Pswd == pswd);
                if (foo != null)
                {
                    var bar = db.Users.FirstOrDefault(x => x.Id == foo.UserId);
                    if (bar != null)
                    {
                        user = bar;
                    }
                }
            }
            return user;
        }

         User IGetUser.SignByEmaiAddress(string emailAddresss, string pswd)
        {
            User user = null;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                var foo = db.UserKeys.FirstOrDefault(x => x.EmailAddressValidate && x.EmailAddress == emailAddresss && x.Pswd == pswd);
                if (foo != null)
                {
                    var bar = db.Users.FirstOrDefault(x => x.Id == foo.UserId);
                    if (bar != null)
                    {
                        user = bar;
                    }
                }
            }
            return user;
        }

         User IGetUser.SignByOpenId(string openId,string pswd)
        {
            User user = null;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                var foo = db.UserKeys.FirstOrDefault(x => x.OpenIdValidate && x.OpenId == openId && x.Pswd == pswd);
                if (foo != null)
                {
                    var bar = db.Users.FirstOrDefault(x => x.Id == foo.UserId);
                    if (bar != null)
                    {
                        user = bar;
                    }
                }
            }
            return user;
        }

        #endregion
    }
}
