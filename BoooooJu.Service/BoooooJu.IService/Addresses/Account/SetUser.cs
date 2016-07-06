using BoooooJu.Service.Core.Contracts.Account;
using BoooooJu.Service.Core.Dal;
using System;
using System.Linq;
using System.Transactions;

namespace BoooooJu.Service.Core.Addresses.Account
{
    public class SetUser : Base.BaseSetData<User>, ISetUser
    {
        #region 用户注册
        public User RegisterByAccountName(User user, string accountName, string pswd)
        {
            User result = null;
            if (user == null || accountName == null || pswd == null)
                return result;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                var userKey = db.UserKeys.FirstOrDefault(x => x.AccountName == accountName && x.AccountNameValidate);
                if (userKey == null)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        db.Entry(user).State = System.Data.Entity.EntityState.Added;
                        db.SaveChanges();
                        UserKey key = new UserKey
                        {
                            AccountName = accountName,
                            AccountNameValidate = true,
                            Pswd = pswd,
                            UserId = user.Id,
                            PswdType = 0,
                            PswdSalt = "0"
                        };
                        db.Entry(key).State = System.Data.Entity.EntityState.Added;
                        db.SaveChanges();
                        scope.Complete();
                        result = user;
                    }
                }
            }
            return result;
        }

        public User RegisterByCellPhone(User user, string cellPhone, string pswd)
        {
            User result = null;
            if (user == null || cellPhone == null || pswd == null)
                return result;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                var userKey = db.UserKeys.FirstOrDefault(x => x.CellPhone == cellPhone && x.CellPhoneValidate);
                if (userKey == null)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        db.Entry(user).State = System.Data.Entity.EntityState.Added;
                        db.SaveChanges();
                        UserKey key = new UserKey
                        {
                            CellPhone = cellPhone,
                            CellPhoneValidate = true,
                            Pswd = pswd,
                            UserId = user.Id,
                            PswdType = 0,
                            PswdSalt = "0"
                        };
                        db.Entry(key).State = System.Data.Entity.EntityState.Added;
                        db.SaveChanges();
                        scope.Complete();
                        result = user;
                    }
                }
            }
            return result;
        }

        public User RegisterByEmailAddress(User user, string emailAddress, string pswd)
        {
            User result = null;
            if (user == null || emailAddress == null || pswd == null)
                return result;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                var userKey = db.UserKeys.FirstOrDefault(x => x.EmailAddress == emailAddress && x.EmailAddressValidate);
                if (userKey == null)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        db.Entry(user).State = System.Data.Entity.EntityState.Added;
                        db.SaveChanges();
                        UserKey key = new UserKey
                        {
                            EmailAddress = emailAddress,
                            EmailAddressValidate = true,
                            Pswd = pswd,
                            UserId = user.Id,
                            PswdType = 0,
                            PswdSalt = "0"
                        };
                        db.Entry(key).State = System.Data.Entity.EntityState.Added;
                        db.SaveChanges();
                        scope.Complete();
                        result = user;
                    }
                }
            }
            return result;
        }

        public User RegisterByOpneId(User user, string opneId)
        {
            User result = null;
            if (user == null || opneId == null)
                return result;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                var userKey = db.UserKeys.FirstOrDefault(x => x.OpenId == opneId && x.OpenIdValidate);
                if (userKey == null)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        db.Entry(user).State = System.Data.Entity.EntityState.Added;
                        db.SaveChanges();
                        UserKey key = new UserKey
                        {
                            OpenId = opneId,
                            OpenIdValidate = true,
                            UserId = user.Id,
                            PswdType = 0,
                            PswdSalt = "0"
                        };
                        db.Entry(key).State = System.Data.Entity.EntityState.Added;
                        db.SaveChanges();
                        scope.Complete();
                        result = user;
                    }
                }
            }
            return result;
        }
        #endregion

        #region 修改密码
        public User AlterPswdByAccountName(string accountName, string pswd)
        {
            User user = null;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                var foo = db.UserKeys.FirstOrDefault(x => x.AccountNameValidate && x.AccountName == accountName);
                if (foo != null)
                {
                    foo.Pswd = pswd;
                    db.Entry(foo).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    user = db.Users.FirstOrDefault(x => x.Id == foo.UserId);
                }
            }
            return user;
        }
        public User AlterPswdByCellPhone(string cellPhone, string pswd)
        {
            User result = null;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                // using (TransactionScope scope = new TransactionScope())
                UserKey foo = db.UserKeys.FirstOrDefault(x => x.CellPhoneValidate && x.CellPhone == cellPhone);
                if (foo != null)
                {
                    foo.Pswd = pswd;
                    db.Entry(foo).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    result = db.Users.FirstOrDefault(x => x.Id == foo.UserId);
                }
            }
            return result;
        }
        public User AlterPswdByEmailAddress(string emailAddress, string pswd)
        {
            User result = null;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                // using (TransactionScope scope = new TransactionScope())
                UserKey foo = db.UserKeys.FirstOrDefault(x => x.EmailAddressValidate && x.EmailAddress == emailAddress);
                if (foo != null)
                {
                    foo.Pswd = pswd;
                    db.Entry(foo).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    result = db.Users.FirstOrDefault(x => x.Id == foo.UserId);
                }
            }
            return result;
        }
        public User AlterPswdByOpenId(string openId, string pswd)
        {
            User user = null;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                UserKey bar = db.UserKeys.FirstOrDefault(x => x.OpenId == openId);
                if (bar != null)
                {
                    bar.Pswd = pswd;
                    db.Entry(bar).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    user = db.Users.FirstOrDefault(x => x.Id == bar.UserId);
                }
            }
            return user;
        }
        #endregion

    }
}
