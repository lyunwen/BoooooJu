using System;
using System.Web.Mvc;
using BoooooJu.Web.Core.Common; 

namespace BoooooJu.WeChat.Core.Controllers
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
            return View();
        }
    }
}
