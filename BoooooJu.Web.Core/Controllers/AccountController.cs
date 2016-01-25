
using BoooooJu.Web.Core.GetUserService;
using BoooooJu.Web.Core.ViewModels.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BoooooJu.Web.Core.Controllers
{
    public class AccountController:Base.BoooooJuController
    {
        private readonly IGetUser _getUserClient;
        public AccountController(IGetUser getUserClient)
        {
            _getUserClient = getUserClient;
        }
        //登入
        public ViewResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public JsonResult SignIn(SignInModel model)
        {
            if(Regex.IsMatch(model.SignName, @"^(0|86|17951)?(13[0-9]|15[012356789]|17[678]|18[0-9]|14[57])[0-9]{8}$"))
            {
                var user = _getUserClient.GetUserByCellPhone(model.SignName);
                if (user.Password == model.Pswd)
                {
                    Session[Base.SessionConfig.BoooooJuer] = null;
                }
            }
            return Json(new { success=false});
        }
        public JsonResult SignOut()
        {
            return Json(new { success=false});
        }
        [Filters.BoAuthorizeAttribute(Base.BoooooJuPermit.PermitG)]
        public ViewResult UserManage()
        {
            return View();
        }
        public PartialViewResult UserManagePage(int index)
        {
            return PartialView();
        }
    }
}
