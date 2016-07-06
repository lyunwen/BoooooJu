using BoooooJu.Web.Core.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BoooooJu.Web.Core.Areas.Vendor.Controllers
{
    
    public class HomeController : BoooooJuController
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OwnInfo()
        {
            return View();
        }
    }
}
