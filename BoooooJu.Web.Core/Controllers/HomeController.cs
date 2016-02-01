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
            var test = _getUserClient.GetDataByPrimaryKey(17);
            return View();
        }
    }
}
