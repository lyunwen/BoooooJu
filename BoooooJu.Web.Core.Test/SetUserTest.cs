using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoooooJu.Web.Core;
using BoooooJu.Web.Core.SetUserService;

namespace BoooooJu.Web.Core.Test
{
    [TestClass]
    public class SetUserTest
    {
        [TestMethod]
        public void InsertUser()
        {
            SetUserClient client = new SetUserClient();
            User user = new User()
            {
                Account = "liuyunwen" + new Random().Next(1000, 9999),
                CellPhone = "13058171032",
                CellPhoneValidate = false,
                EmailValidate = false,
                NickName = "zaizaiyou",
                Password = "qq123123",
                Sex = 2,
                PasswordSalt = "jyHf7w",
                PasswordSaltType = 1
            };
             user = client.Insert(user);
        }
    }
   
}
