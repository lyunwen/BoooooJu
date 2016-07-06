using BoooooJu.Web.Core.ViewModels.Partial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BoooooJu.Web.Core.Controllers
{
    /// <summary>
    /// 组件形式界面 耦合终端
    /// </summary>
    public class ComponentController : Base.BoooooJuController
    {
        public ActionResult PageSwitch(int style = 0)
        {
            return View();
        }
    }
}
