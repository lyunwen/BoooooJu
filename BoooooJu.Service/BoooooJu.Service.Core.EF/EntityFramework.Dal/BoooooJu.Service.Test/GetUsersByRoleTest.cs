using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoooooJu.Service.Core.Addresses.Account;
using BoooooJu.Service.Core.Contracts.Account;
using BoooooJu.Service.Core.QueryParameter;
using BoooooJu.Service.Core.Dal.OBModels;

namespace BoooooJu.Service.Test
{
    [TestClass]
    public class GetUsersByRoleTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IGetUser test = new GetUser(); 
            var t1 = test.GetUserInfosByRole(new Page { PageIndex = 1 }, 2,User_Rank.Id,"");
            var t4 = test.GetUserInfosByRole(new Page { PageIndex = 1 }, 2,User_Rank.Id,null);
            var t2 = test.GetUserInfosByRole(new Page { PageIndex = 1 }, 2, User_Rank.NickName,null);
            var t3 = test.GetUserInfosByRole(new Page { PageIndex = 1 }, 2, User_Rank.Sex,null);
            var t5 = test.GetUserInfosByRole(new Page { PageIndex = 1 }, 2, User_Rank.Sex,null);
        }
    }
}
