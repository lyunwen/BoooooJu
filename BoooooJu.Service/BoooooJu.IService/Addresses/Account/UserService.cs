using BoooooJu.Service.Core.ServiceContracts.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoooooJu.Service.Core.Dal;

namespace BoooooJu.Service.Core.Addresses.Account
{
    public class UserService : IUserService
    {
        public User FindUserById(int id)
        {
            User user = null;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                var t = db.DC_User.FirstOrDefault(x => x.Id == id);
                var t2 = db.DC_User.FirstOrDefault(x => x.Id ==1);
                user = db.Set<User>().Find(id);
                var t3 = db.DC_User.FirstOrDefault(x => x.Id == 1);
            }
            return user;
        }

        public User FindUserInfoByCellPhone(string cellPhone)
        {
            throw new NotImplementedException();
        }

        public User FindUserInfoByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public User FindUserInfoById(int id)
        {
            throw new NotImplementedException();
        }

        public User FindUserInfoByName(string name)
        {
            throw new NotImplementedException();
        }

        public User FindUserInfoByOpenId(string openId)
        {
            throw new NotImplementedException();
        }

        public User InsertUser(User user)
        {
            throw new NotImplementedException();
        }

        public User InsertUserInfo(User user)
        {
            throw new NotImplementedException();
        }
    }
}
