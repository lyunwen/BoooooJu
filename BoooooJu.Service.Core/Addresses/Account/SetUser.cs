using BoooooJu.Service.Core.Contracts;
using BoooooJu.Service.Core.Contracts.Account;
using BoooooJu.Service.Core.Dal;
using System.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.Core.Addresses.Account
{
    public class SetUser : Base.BaseSetData<User>, ISetUser
    {
        public User RegisterUser(User user, string pswd)
        {
            User result = null;
            if (user == null || pswd == null)
                return result;
            try
            {
                using (BoooooJuDB db = new BoooooJuDB())
                {
                    db.Users.Add(user);
                    UserKey key = new UserKey
                    {
                        UserId = user.Id,
                        Pswd = pswd,
                        PswdSalt = "0",
                        PswdType = 0
                    };
                    db.UserKeys.Add(key);
                    db.SaveChanges();
                    result = user;
                }
            }
            catch
            {
                // ignore
            }
            return user;
        }

        public User AlterPswdByAccounName(string accountName, string pswd)
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
        public User AliterPswdByOpenId(string openId, string pswd)
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
    }
}
