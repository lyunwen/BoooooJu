using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoooooJu.Service.Core.Addresses.SMSService;

namespace BoooooJu.Service.Test
{
    [TestClass]
    public class DefaultSMSServiceTest
    {
        [TestMethod]
        public void Send()
        {
            DefaultSMSService service = new DefaultSMSService();
            var result = service.Send(new System.Collections.Generic.List<string> { "8613058171032" }, "你好，你的注册验证码是1234【美联】");
        }
    }
}
