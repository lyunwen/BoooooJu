using BoooooJu.Web.Core.ViewModels.Partial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BoooooJu.WeChat.Core.Controllers
{
    //存放 网页头部、尾部等通用局部界面
    public class PartialController : Base.BoooooJuController
    {

        public PartialViewResult Header()
        {
            HeaderModel model = null;
            if (boooooJuer != null)
            {
                model = new HeaderModel
                {
                    Id = boooooJuer.Id,
                    NickName = boooooJuer.NickName,
                    IsSign = true
                };
            }
            return PartialView(model);
        }
    }
}
