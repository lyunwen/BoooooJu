using System.Linq;
using BoooooJu.Service.Core.QueryParameter.Base;
using System.Collections.Generic;
using BoooooJu.Service.Core.Contracts;
using System;
using BoooooJu.Service.Core.Dal;
using BoooooJu.Service.Core.Addresses.Base;

namespace BoooooJu.Service.Core.Addresses
{
    public class SetUser : BaseSetData<User>, ISetUser
    {   
        int ISetUser.InsertUser(User info)
        {
            int result = 0;
            using (Dal.BoooooJuDB db = new Dal.BoooooJuDB())
            { 
                db.Users.Add(info);
                result = db.SaveChanges();
            }
            return result;
        } 
    }
}
