using BoooooJu.Service.Api.Dto.Account; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.DB.Aspects.Account
{
    public interface IAccountQuery
    {
        UserBO UserBOGetById(long id);
    }
    public class AccountQuery : IAccountQuery
    {
        UserBO IAccountQuery.UserBOGetById(long id)
        {
            return new UserBO { Id = id, NickName = "testNickName", AccountName = "testAccountName", MobilePhone = "13058171032"};
        }
    } 
}
