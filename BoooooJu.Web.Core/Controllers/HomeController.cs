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
        private readonly ISetUser _setUserClient;
        private readonly IGetUser _getUserClient;

        public HomeController(ISetUser setUserClient, IGetUser getUserClient)
        {
            _setUserClient = new BoooooJuClientResolver<ISetUser>(setUserClient).Client;
            _getUserClient = new BoooooJuClientResolver<IGetUser>(getUserClient).Client;
        }
        public ActionResult Index()
        {
            var hh = Base.UnityClientCall<ISetUser>.GetClient().RegisterByAccountName(new SetUserService.User
            {
                NickName = "zaizaiyou",
                Signature = "世界那么大",
                Sex = 2,
                CreateTime = DateTime.Now,
                Role = 0
            }, "zaizaiyou09"+new Random().Next(1000,9999), "qq123123");
            var test1 = Base.UnityClientCall<IGetUser>.GetClient().GetDataByPrimaryKey(hh.Id);
            var test = _getUserClient.GetDataByPrimaryKey(hh.Id);
            return View();
        }
    }
}
