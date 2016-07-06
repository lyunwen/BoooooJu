using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BoooooJu.Web.Core.Controllers.Base
{
    public class BoooooJuController : Controller
    {
        internal BoooooJuer boooooJuer
        {
            get
            {
                return Session[SessionConfig.BoooooJuer] as BoooooJuer;
            }
        }
        /// <summary>
        /// 刷新当前登入用户信息
        /// </summary>
        internal void ReflashLoginUser()
        {
            ;
        }
    }
}
