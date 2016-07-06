//using BoooooJu.Web.Core.AccountService;
//using BoooooJu.Web.Core.Clients;
//using BoooooJu.Web.Core.Controllers.Base;
//using BoooooJu.Web.Core.Fittings;
//using BoooooJu.Web.Core.ViewModels.Account;
//using System;
//using System.Text.RegularExpressions;
//using System.Web.Mvc;

//namespace BoooooJu.Web.Core.Controllers
//{
//    public class AccountController : BoooooJuController
//    {
//        //登入 
//        public ViewResult SignIn(string returnUrl = null)
//        {
//            ViewData["returnUrl"] = returnUrl;
//            return View();
//        }
//        [HttpPost]
//        public JsonResult SignIn(SignInModel model)
//        {
//            UserInfo user = null;
//            if (model.Pswd == null || model.SignName == null)
//                return Json(new { success = false });
//            if (Regex.IsMatch(model.SignName, @"^(0|86|17951)?(13[0-9]|15[012356789]|17[678]|18[0-9]|14[57])[0-9]{8}$"))
//            {
//                user = new UnityBaseService<ISignInService>().GetClient().SignByCellPhone(model.SignName, model.Pswd);
//            }
//            else
//            {
//                if (Regex.IsMatch(model.SignName, @"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$"))
//                {
//                    user = new UnityBaseService<ISignInService>().GetClient().SignByEmaiAddress(model.SignName, model.Pswd);
//                }
//                else
//                {
//                    user = new UnityBaseService<ISignInService>().GetClient().SignByAccountName(model.SignName, model.Pswd);
//                }
//            }
//            if (user != null)
//            {
//                Session[SessionConfig.BoooooJuer] = new Base.BoooooJuer
//                {
//                    Id = user.UserId,
//                    Logon = DateTime.Now,
//                    NickName = user.UserName,
//                    Permits = user.Role,
//                    LogonIp = GetIP()
//                };
//                if ((user.Role & (int)BoooooJuPermit.SuperManager) == (int)BoooooJuPermit.Manager)
//                    return Json(new { success = true, url = "/SuperManager/Home/Index" });
//                if ((user.Role & (int)BoooooJuPermit.Manager) == (int)BoooooJuPermit.Manager)
//                    return Json(new { success = true, url = "/Manager/Home/Index" });
//                if ((user.Role & (int)BoooooJuPermit.Vendor) == (int)BoooooJuPermit.Vendor)
//                    return Json(new { success = true, url = "/Vendor/Home/Index" });
//                if ((user.Role & (int)BoooooJuPermit.Agent) == (int)BoooooJuPermit.Agent)
//                    return Json(new { success = true, url = "/Agent/Home/Index" });
//                if ((user.Role & (int)BoooooJuPermit.Buyer) == (int)BoooooJuPermit.Buyer)
//                    return Json(new { success = true, url = "/Buyer/Home/Index" });

//                return Json(new { success = true, url = "/Home/Index" });
//            }
//            else
//            {
//                return Json(new { success = false });
//            }
//        }

//        public JsonResult SignOut()
//        {
//            Session[SessionConfig.BoooooJuer] = null;
//            return Json(new { success = true });
//        }

//        [Filters.BoAuthorize(BoooooJuPermit.Manager)]
//        public ViewResult UserManage()
//        {
//            return View();
//        }
//        public PartialViewResult UserManagePage(int index)
//        {
//            return PartialView();
//        }

//        public ActionResult Register()
//        {
//            return View();
//        }
//        [HttpPost]
//        public JsonResult Register(RegisterModel model)
//        {
//            if (!ModelState.IsValid)
//            {
//                return Json(new { success = false });
//            }
//            var result = new UnityBaseService<IRegisterService>().GetClient().RegisterByAccountName(new User
//            {
//                CreateTime = DateTime.Now,
//                Name = model.AccountName,
//                Sex = model.Sex,
//                Signature = model.Signature
//            }, model.AccountName, model.Pswd);
//            if (result == null)
//            {
//                return Json(new { success = false });
//            }
//            else
//            {
//                return Json(new { success = true });
//            }
//        }
//        public JsonResult FindUserByAccountName(string accountName)
//        {
//            var user = new UnityBaseService<IQueryService>().GetStaticClient().FindUserInfoByAccountName(accountName);
//            if (user == null)
//            {
//                return Json(new { success = true });
//            }
//            else
//            {
//                return Json(new { success = false });
//            }
//        }

//        #region    private method
//        private string GetIP()
//        {
//            string ip = string.Empty;
//            if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.ServerVariables["HTTP_VIA"]))
//                ip = Convert.ToString(System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"]);
//            if (string.IsNullOrEmpty(ip))
//                ip = Convert.ToString(System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"]);
//            return ip;
//        }
//        #endregion
//    }
//}