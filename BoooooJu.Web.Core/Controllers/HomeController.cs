using BoooooJu.Web.Core.Filters;
using System;
using System.Collections.Generic;
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
          //  TestService.MySimpleServiceClient client = new TestService.MySimpleServiceClient();
          //  client.ClientCredentials.UserName.UserName = "xiaozhuang";
          //  client.ClientCredentials.UserName.Password = "123456";
          //var key=  client.Hello("ffffffff");
            SetUserService.SetUserClient client1 = new SetUserService.SetUserClient();
            ServicePointManager.ServerCertificateValidationCallback += ServerCertificateValidationCallback;
            //client1.ClientCredentials.UserName.UserName = "xiaozhuang";
            //    client1.ClientCredentials.UserName.Password = "123456";
            client1.RegisterByAccountName(new SetUserService.User()
            {
                NickName = "zaizaiyou",
                Sex = 2,
                CreateTime = DateTime.Now,
                Role = 0,
                Signature = "世界这么大" + new Random().Next(1000, 9999)
            }, "lyw" + new Random().Next(100, 999), "qq123123");
            SetUserService.User y = _setUserClient.RegisterByAccountName(new SetUserService.User()
            {
                NickName = "zaizaiyou",
                Sex = 2,
                CreateTime = DateTime.Now,
                Role = 0,
                Signature = "世界这么大" + new Random().Next(1000, 9999)
            },"lyw"+new Random().Next(100,999),"qq123123");


            //TestWCFService.MySimpleServiceClient client = new ClientWeb.TestWCFService.MySimpleServiceClient();

            //client.ClientCredentials.UserName.UserName = "xiaozhuang";

            //client.ClientCredentials.UserName.Password = "123456";

            //lbMessage.Text = client.PrintMessage(txtMessage.Text);






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
