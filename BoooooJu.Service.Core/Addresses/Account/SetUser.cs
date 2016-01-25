using BoooooJu.Service.Core.Contracts;
using BoooooJu.Service.Core.Contracts.Account;
using BoooooJu.Service.Core.Dal;
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
    }
}
