
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web;
using System.Net; 
using System.IO;
using Common.Logger;

namespace BoooooJu.WeChat.Core.Controllers
{
    public class WeChatController : Base.BoooooJuController
    {
        private const string APPID = "wx91cabe9e6c771402";
        private const string APPSECRET = "d4624c36b6795d1d99dcf0547af5443d";
        private const string TOKEN = "boooooju";

        private static string AccessToken_Str = string.Empty;
        private static DateTime AccessToken_ValidTime = DateTime.MinValue;

        private readonly ILogger _loger = new Clients.UnityLogerCall<ILogger>().GetClient();
        private readonly Common.WXHelper _wxHelper = new Common.WXHelper();
        public ActionResult Index()
        {
            var token = _wxHelper.GetAccessToken();
            return Redirect(_wxHelper.GetUserInfoUrl("http://120.24.185.131/WeChat/GetUserInfo"));
        }
        [HttpGet]
        public ActionResult Link(string signature, string timestamp, string nonce, string echostr)
        {
            _loger.Log(string.Format("signature:{0}--timestamp:{1}--nonce:{2}--echostr:{3}", signature, timestamp, nonce, echostr), null, null, LogLevel.Info);
            //对signature的验证
            Response.Write(echostr);
            Response.End();
            return Content("Link success!");
        }
        /// <summary>
        /// 获取用户基本信息
        /// </summary>
        /// <returns></returns>
        public ActionResult GetUserInfo(string state, string code)
        {
            if (state == "booooo")
            {
                Common.WXHelper.UserAuth info = _wxHelper.GetUserAuthToken(code);
            }
            else
            {
                _loger.Log("返回state非[booooo],可能为非法请求,获取用户信息失败");
            }
            return Content("success!");
        }
        public class TokenInfo
        {
            public string access_token { get; set; }
            public int expires_in { get; set; }
        }
    }
}
