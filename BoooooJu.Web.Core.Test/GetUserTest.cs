﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BoooooJu.Web.Core.Test
{
    [TestClass]
    public class GetUserTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            GetUserService.IGetUser client = new GetUserService.GetUserClient();
            var value = client.GetUserByAccount("liuyunwen13058");
        }
    }
}
