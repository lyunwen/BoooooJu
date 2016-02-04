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
        //private readonly IGetUser _getUserClient;
        //public HomeController( IGetUser getUserClient)
        //{
        //    _getUserClient = new BoooooJuClientResolver<IGetUser>(getUserClient).Client;
        //}
        public ActionResult Index()
        {
          var bar=  Base.UnityClientCall<IGetUser>.GetClient().GetDataByPrimaryKey(1);
            var baz = Base.UnityClientCall<ISetUser>.GetClient().RegisterByAccountName(new SetUserService.User
            {
                NickName = "zaizaiyou",
                Signature = "世界那么大",
                Sex = 2,
                CreateTime = DateTime.Now,
                Role = 0
            }, "ttttttttttt2", "qqqq123123");

            var foo = Base.UnityClientCall<IGetUser>.GetClient().GetDataByPrimaryKey(baz.Id);
            //  var test1 = Base.UnityClientCall<IGetUser>.GetClient().GetDataByPrimaryKey(1);
            return View();
        }
    }
}
