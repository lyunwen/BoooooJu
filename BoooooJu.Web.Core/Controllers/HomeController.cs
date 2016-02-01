using System;
using System.Web.Mvc;
using BoooooJu.Web.Core.Common;
using BoooooJu.Web.Core.GetUserService;
using BoooooJu.Web.Core.SetUserService;

namespace BoooooJu.Web.Core.Controllers
{
    // [BoAuthorize(Base.BoooooJuPermit.All)]
    public class HomeController : Base.BoooooJuController
    {
        ISetUser _setUserClient;
        IGetUser _getUserClient;

        public HomeController(ISetUser setUserClient, IGetUser getUserClient)
        {
            _setUserClient = new BoooooJuClientResolver<ISetUser>(setUserClient).Client;
            _getUserClient = new BoooooJuClientResolver<IGetUser>(getUserClient).Client;
        }
        public ActionResult Index()
        {

            _setUserClient.RegisterByAccountName(new SetUserService.User()
            {
                NickName = "zaizaiyou",
                Sex = 2,
                CreateTime = DateTime.Now,
                Role = 0,
                Signature = "世界这么大" + new Random().Next(1000, 9999)
            }, "lyw" + new Random().Next(100, 999), "qq123123");
            return View();
            //private static bool ServerCertificateValidationCallback(
            //  object sender,
            //  X509Certificate certificate,
            //  X509Chain chain,
            //  SslPolicyErrors sslPolicyErrors)
            //{
            //    return true;
            //}
        }
    }
}
