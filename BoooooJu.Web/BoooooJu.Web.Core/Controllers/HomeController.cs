using System;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Web;
using Common.Logger;
using System.Net.Http;
using ServiceStack.Text;
using BoooooJu.Service.Api.Dto.Account;
using BoooooJu.Web.Core.Filters;
//using Loger = BoooooJu.Web.Core.Clients.UnityLogerCall<Common.Loger.I.ILoger>;

namespace BoooooJu.Web.Core.Controllers
{
    [BoAuthorize(Base.BoooooJuRole.All)]
    public class HomeController : Base.BoooooJuController
    {
        // [Filters.StaticFileWriteFilter,Filters.BoAuthorize(Base.BoooooJuPermit.Buyer|Base.BoooooJuPermit.Agent)] 
        public async Task<ActionResult> Index()
        {
            Clients.UserService client3 = new Clients.UserService();
            await Clients.UserService.GetUserBOById(23);
            int y = await Clients.UserService.ResgiterByUserName("liuyunwen20160626", "qq123123", "fromtype1");
            #region 日志组件测试
            ////首次加载测试
            //new Bus.Clients.UnityLogerClient().GetStaticClient().CreateLogger().Log("测试日志组件2", null, null, LogLevel.Info);
            ////普通测试
            //new Bus.Clients.UnityLogerClient().GetStaticClient().CreateLogger().Log("测试日志组件2", null, null, LogLevel.Info);
            ////异步测试 
            //await new Bus.Clients.UnityLogerClient().GetStaticClient().CreateLogger().LogAsync("测试日志组件2", null, null, LogLevel.Info);
            #endregion
            #region 账户模块客户端测试
            //var baz = new Bus.Clients.UnityAccountClient().GetStaticClient().Register(new Bus.Clients.Account.Command.Register.RegisterByEmailCommand("l_yunwen@qq.com", "qq1444423123"));
            //var foo = new Bus.Clients.UnityAccountClient().GetStaticClient().Register(new Bus.Clients.Account.Command.Register.RegisterByPhoneCommand("13058171032", "1234567", "fromTypeTest"));
            //var bar = new Bus.Clients.UnityAccountClient().GetStaticClient().UserBOGetById(10010);
            ReflashLoginUser();
            #endregion
            return View();
        }
        public ActionResult Test(string name)
        {
            return View();
        }
    }
}