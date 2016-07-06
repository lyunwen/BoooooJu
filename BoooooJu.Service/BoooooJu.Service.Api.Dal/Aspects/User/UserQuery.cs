using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoooooJu.Service.Api.Dto.Account;

namespace BoooooJu.Service.Api.Dal.Aspects.User
{
    public interface IUserQuery
    {
        Dto.Account.UserBO UserBOGetById(long id);
    }
    public class UserQuery : IUserQuery
    {
        UserBO IUserQuery.UserBOGetById(long id)
        {
            return new UserBO { Id = id, NickName = "testNickName", AccountName = "testAccountName", MobilePhone = "13058171032" };
        }
    }
}
