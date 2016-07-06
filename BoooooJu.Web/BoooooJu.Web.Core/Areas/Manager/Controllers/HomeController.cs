using BoooooJu.Web.Core.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BoooooJu.Web.Core.Areas.Manager.Controllers
{
   // [Filters.BoAuthorize(BoooooJuPermit.Manager)]
    public class HomeController : BoooooJuController
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
