using BoooooJu.Web.Core.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BoooooJu.Web.Core.Controllers
{
    // [BoAuthorize(Base.BoooooJuPermit.All)]
    public class HomeController : Base.BoooooJuController
    {
        private readonly SetUserService.ISetUser _setUserClient;
        public HomeController(SetUserService.ISetUser SetUserClient)
        {
            _setUserClient = SetUserClient;
        }
        public  ActionResult Index()
        {
            SetUserService.User y =  _setUserClient.Insert(new SetUserService.User()
            {
                Account = "liuyunwen" + new Random().Next(1000, 9999),
                CellPhone = "13058171" + new Random().Next(100, 999),
                CellPhoneValidate = false,
                EmailValidate = false,
                NickName = "zaizaiyou",
                Password = "qq123123",
                EmailAdress = new Random().Next(1000, 9999) + "@qq.com",
                Sex = 2,
                PasswordSalt = "jyHf7w",
                PasswordSaltType = 1,
                CreateTime = DateTime.Now
            });
            return View();
        }
    }
}
