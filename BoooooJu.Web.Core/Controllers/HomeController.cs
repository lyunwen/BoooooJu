using BoooooJu.Web.Core.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BoooooJu.Web.Core.Controllers
{
    // [BoAuthorize(Base.BoooooJuPermit.All)]
    public class HomeController : Base.BoooooJuController
    {
        private readonly SetUserService.ISetUser _setUserClient;
        public HomeController(SetUserService.ISetUser SetUserClient)
        {
            _setUserClient = SetUserClient; 
        }
        public  ActionResult Index()
        { 
            SetUserService.SetUserClient client1 = new SetUserService.SetUserClient(); 
            client1.ClientCredentials.UserName.UserName = "xiaozhuang";
             client1.ClientCredentials.UserName.Password = "123456"; 
            client1.RegisterByAccountName(new SetUserService.User()
            {
                NickName = "zaizaiyou",
                Sex = 2,
                CreateTime = DateTime.Now,
                Role = 0,
                Signature = "世界这么大" + new Random().Next(1000, 9999)
            }, "lyw" + new Random().Next(100, 999), "qq123123");
            GetUserService.GetUserClient client2 = new GetUserService.GetUserClient();
            client2.ClientCredentials.UserName.UserName = "xiaozhuang";
            client2.ClientCredentials.UserName.Password = "123456";
            client2.SignByAccountName("lyw285", "qq123123");
            var p = client2.GetUserById(50);

            return View();
        }
        private static bool ServerCertificateValidationCallback(
          object sender,
          X509Certificate certificate,
          X509Chain chain,
          SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}
