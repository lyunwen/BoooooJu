using BoooooJu.Service.Core.Contracts;
using BoooooJu.Service.Core.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoooooJu.Service.Core.QueryParameter.Base;
using BoooooJu.Service.Core.Contracts.Account;
using BoooooJu.Service.Core.QueryParameter;
using BoooooJu.Service.Core.Dal.OBModels;

namespace BoooooJu.Service.Core.Addresses.Account
{
    public class GetUser : Base.BaseGetData<User>, IGetUser
    {
        /// <summary>
        /// 通过帐户名获取用户信息
        /// </summary>
        /// <param name="accountName"></param>
        /// <returns></returns>
        User IGetUser.GetUserByAccountName(string accountName)
        {
            User user = null;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                UserKey key = db.UserKeys.FirstOrDefault(x => x.AccountNameValidate && x.AccountName == accountName);
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

        KeyValuePair<Page, List<User>> IGetUser.GetUserInfosByRole(Page page, int role, User_Rank rank, string nickName)
        {
            KeyValuePair<Page, List<User>> result = new KeyValuePair<Page, List<User>>(page, new List<User>());
            if (page == null)
            {
                return result;
            } 
            //using (BoooooJuDB db = new BoooooJuDB())
            //{
            //    IQueryable<UserKey> query = null;
            //    if (string.IsNullOrEmpty(nickName))
            //    {
            //        query = db.UserKeys.Where(x => (x.Role & role) == role);
            //    }
            //    else
            //    {
            //        var t = from userKeys in db.UserKeys
            //                join users in db.Users on userKeys.UserId equals users.Id
            //                select db;

            //        t.ToList();
            //    }
            //    if (page.Sort == Sort.Asc)
            //    {
            //        switch (rank)
            //        {
            //            case User_Rank.Id: query = query.OrderBy(x => x.Id); break;
            //            case User_Rank.CreateTime: query = query.OrderBy(x => x.CreateTime); break;
            //            case User_Rank.NickName: query = query.OrderBy(x => x.NickName); break;
            //            case User_Rank.Role: query = query.OrderBy(x => x.Role); break;
            //            case User_Rank.Sex: query = query.OrderBy(x => x.Sex); break;
            //            default: query = query.OrderBy(x => x.Sex); break;
            //        }
            //    }
            //    else
            //    {
            //        switch (rank)
            //        {
            //            case User_Rank.Id: query = query.OrderByDescending(x => x.Id); break;
            //            case User_Rank.CreateTime: query = query.OrderByDescending(x => x.CreateTime); break;
            //            case User_Rank.NickName: query = query.OrderByDescending(x => x.NickName); break;
            //            case User_Rank.Role: query = query.OrderByDescending(x => x.Role); break;
            //            case User_Rank.Sex: query = query.OrderByDescending(x => x.Sex); break;
            //            default: query = query.OrderByDescending(x => x.Sex); break;
            //        }
            //    }
            //    var datas = query.ToList();
            //    if (datas != null)
            //    {
            //        result.Key.TotalCounts = datas.Count;
            //        if (page.PageSize > 0)
            //        {
            //            result.Key.TotalPages = result.Key.TotalCounts / page.PageSize + (result.Key.TotalCounts % page.PageSize > 0 ? 1 : 0);
            //        }
            //        var value = datas.Skip((page.PageIndex - 1) * page.PageSize).Take(page.PageSize).ToList();
            //        result.Value.AddRange(value);
            //    }
            //}
            return result;
        }

        #region 登入
        User IGetUser.SignByAccountName(string accountName, string pswd)
        {
            User user = null;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                var foo = db.UserKeys.FirstOrDefault(x => x.AccountNameValidate && x.AccountName == accountName && x.Pswd == pswd);
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

        User IGetUser.SignByOpenId(string openId, string pswd)
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
