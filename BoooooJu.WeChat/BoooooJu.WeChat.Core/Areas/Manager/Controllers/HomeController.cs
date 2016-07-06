using BoooooJu.WeChat.Core.Controllers.Base;
using System.Web.Mvc;

namespace BoooooJu.Web.Core.Areas.Manager.Controllers
{
    [WeChat.Core.Filters.BoAuthorize(BoooooJuRole.All)]
    public class HomeController : BoooooJuController
    {
        public HomeController()
        {

        }
        public ViewResult Index()
        {
            return View();
        }
    }
}
