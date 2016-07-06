using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BoooooJu.Web.Core.Controllers
{
    public class TestController : Base.BoooooJuController
    {
        public ActionResult WebSorketTest()
        {
         //   LogLog.Error(typeof(TestController),"go~");
            return View();
        }
    }
}
