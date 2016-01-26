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
            if (accountName == null || pswd == null)
                return user;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    var foo = db.Users.FirstOrDefault(x => x.Account == accountName);
                    if (foo != null)
                    {
                        var bar = db.UserKeys.FirstOrDefault(x => x.UserId == foo.Id);
                        if (bar != null)
                        {
                            bar.Pswd = pswd;
                            db.Entry(bar).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            user = foo;
                        }
                    }
                }
            }
            return user; 
        }
        public User AlterPswdByCellPhone(string cellPhone, string pswd)
        {
            User result = null;
            if (cellPhone == null || pswd == null)
                return result;
            using(BoooooJuDB db=new BoooooJuDB())
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    User foo = db.Users.FirstOrDefault(x => x.CellPhoneValidate && x.CellPhone == cellPhone);
                    if (foo != null)
                    {
                        UserKey bar = db.UserKeys.FirstOrDefault(x => x.UserId == foo.Id);
                        if (bar != null)
                        {
                            bar.Pswd = pswd;
                            db.Entry(bar).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            result = foo;
                        }
                    }
                }
            }
            return result;
        }
    }
}
