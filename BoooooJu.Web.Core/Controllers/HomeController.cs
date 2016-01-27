using BoooooJu.Web.Core.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
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
            SetUserService.User y = _setUserClient.RegisterByAccountName(new SetUserService.User()
            {
                NickName = "zaizaiyou",
                Sex = 2,
                CreateTime = DateTime.Now,
                Role = 0,
                Signature = "世界这么大" + new Random().Next(1000, 9999)
            },"lyw"+new Random().Next(100,999),"qq123123");
            return View();
        }
    }
}
