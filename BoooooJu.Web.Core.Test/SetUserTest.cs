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
                NickName = "zaizaiyou",
                Sex = 2,
                CreateTime = DateTime.Now,
                Signature = "世界好大",
                Role = 0
            };
            user = client.RegisterByCellPhone(user, "1305817" + new Random().Next(1000, 9999),"qq123123");
        }
    }

}
