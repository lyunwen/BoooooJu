using BoooooJu.Web.Core.ViewModels.Partial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BoooooJu.Web.Core.Controllers
{
    //存放 网页头部、尾部等通用局部界面
    public class PartialController : Base.BoooooJuController
    {
        public PartialViewResult DefaultHeader(int style = 0)
        {
            DefaultHeaderModel model = new DefaultHeaderModel { ShowStyle = style, IsSign = false };
            if (boooooJuer != null)
            {
                model.Id = boooooJuer.Id;
                model.NickName = boooooJuer.NickName;
                model.IsSign = true;
            }
            return PartialView(model);
        }
    }
}