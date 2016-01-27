
using BoooooJu.Web.Core.GetUserService;
using BoooooJu.Web.Core.SetUserService;
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
    public class AccountController : Base.BoooooJuController
    {
        private readonly IGetUser _getUserClient;
        private readonly ISetUser _setUserClient;
        public AccountController(IGetUser getUserClient,ISetUser setUserClient)
        {
            _getUserClient = getUserClient;
            _setUserClient = setUserClient;
        }
        //登入
        public ViewResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public JsonResult SignIn(SignInModel model)
        {
            GetUserService.User user = null;
            if (model.Pswd == null || model.SignName == null)
                return Json(new { success = false });
            if (Regex.IsMatch(model.SignName, @"^(0|86|17951)?(13[0-9]|15[012356789]|17[678]|18[0-9]|14[57])[0-9]{8}$"))
            {
                user = _getUserClient.SignByCellPhone(model.SignName, model.Pswd);
            }
            else
            {
                if (Regex.IsMatch(model.SignName, @"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$"))
                {
                    user = _getUserClient.SignByEmaiAddress(model.SignName, model.Pswd);
                }
                else
                {
                    user = _getUserClient.SignByAccountName(model.SignName, model.Pswd);
                }
            }
            if (user != null)
            {
                Session[Base.SessionConfig.BoooooJuer] = User;
                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false });
            }
        }

        public JsonResult SignOut()
        {
            Session[Base.SessionConfig.BoooooJuer] = null;
            return Json(new { success = false });
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

        public ActionResult Register()
        {
            RegisterModel model = new RegisterModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            _setUserClient.RegisterByAccountName(new SetUserService.User {
                CreateTime =DateTime.Now,
                 NickName=model.NickName,
                  Sex=model.Sex,
                   Signature=model.Signature,
                    Role=1
            }, model.AccountName,model.Pswd);
            return View(model);
        }
    }
}
