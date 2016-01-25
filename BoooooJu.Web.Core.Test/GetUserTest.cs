using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BoooooJu.Web.Core.Test
{
    [TestClass]
    public class GetUserTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string goooo = "3";
            BoooooJuService.IGetUser client = new BoooooJuService.GetUserClient();
            var value = client.GetUserByAccount("liuyunwen13058");
        }
    }
}
