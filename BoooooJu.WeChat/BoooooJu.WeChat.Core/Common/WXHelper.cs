
using Common.Logger;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.WeChat.Core.Common
{
    public class WXHelper
    {
        private ILogger _loger = new Clients.UnityLogerCall<ILogger>().GetClient();

        private const string APPID = @"wxb3d367f1a0ae05a4";
        private const string APPSECRET = @"d4624c36b6795d1d99dcf0547af5443d";
        private const string TOKEN = @"boooooju";
        /// <summary>
        /// 接口授权AccessToken
        /// </summary>
        private static string AccessToken_Str = string.Empty;
        private static DateTime AccessToken_ValidTime = DateTime.MinValue;
        /// <summary>
        /// 网页授权AccessToken
        /// </summary>
        private static string AccessToken_PageAuth = string.Empty;

        private static DateTime AccessToken_PageAuth_ValidTime = DateTime.MinValue;


        internal string GetAccessToken()
        {
            if (DateTime.Now > AccessToken_ValidTime)
            {
                lock (this)
                {
                    if (DateTime.Now > AccessToken_ValidTime)
                    {
                        WebClient WXclient = new WebClient();
                        AccessToken_ValidTime = DateTime.Now;
                        string foo = WXclient.DownloadString(string.Format(@"https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={0}&secret={1}", APPID, APPSECRET));
                        JsonSerializer<TokenInfo> serialiizer = new JsonSerializer<TokenInfo>();
                        TokenInfo tokenInfo = serialiizer.DeserializeFromString(foo);
                        if (tokenInfo != null)
                        {
                            AccessToken_Str = tokenInfo.access_token;
                            AccessToken_ValidTime = AccessToken_ValidTime.AddSeconds(tokenInfo.expires_in);
                        }
                    }
                }
            }
            return AccessToken_Str;
        }

        internal string GetUserInfoUrl(string redirect_uri)
        {
            return string.Format(@"https://open.weixin.qq.com/connect/oauth2/authorize?appid={0}&redirect_uri={1}&response_type=code&scope=snsapi_userinfo&state=booooo#wechat_redirect", APPID, redirect_uri);
        }

        #region 获取用户信息

        /// <summary>
        /// 用户网页授权返回信息
        /// </summary>
        internal class UserAuth
        {
            internal string access_token { get; set; }
            internal int expires_in { get; set; }
            internal string refresh_token { get; set; }
            internal string openid { get; set; }
            internal string scope { get; set; }
            internal string unionid { get; set; }
        }

        internal UserAuth GetUserAuthToken(string code)
        {
            WebClient WXclient = new WebClient();
            string foo = WXclient.DownloadString(string.Format(@"https://api.weixin.qq.com/sns/oauth2/access_token?appid={0}&secret={1}&code={2}&grant_type=authorization_code", APPID, APPSECRET, code));
            JsonSerializer<UserAuth> serializer = new JsonSerializer<UserAuth>();
            UserAuth authInfo = serializer.DeserializeFromString(foo);
            return authInfo;
        }
        #endregion

        #region 微信菜单
        internal bool CreateMenu()
        {
            string address = string.Format(@"https://api.weixin.qq.com/cgi-bin/menu/create?access_token={0}", GetAccessToken());
            string postData = "{\"button\":[{\"name\":\"菜单看看\",\"sub_button\":[{\"type\":\"click\",\"name\":\"子菜单一一\",\"key\":\"V1001_HELLO_WORLD\"},{\"type\":\"click\",\"name\":\"子菜单一二\",\"key\":\"V1001_GOOD\"}]},{\"name\":\"菜单二\",\"sub_button\":[{\"type\":\"click\",\"name\":\"子菜单二一\",\"key\":\"V1002_HELLO_WORLD\"},{\"type\":\"click\",\"name\":\"子菜单二二\",\"key\":\"V1002_GOOD\"}]},{\"name\":\"菜单三\",\"sub_button\":[{\"type\":\"click\",\"name\":\"子菜单三一\",\"key\":\"V1003_GOOD\"}]}]}";

            WebClient WXclient = new WebClient();

            return false;
        }
        #endregion

        /// <summary>
        /// 基本access_token
        /// </summary>
        internal class TokenInfo
        {
            public string access_token { get; set; }
            public int expires_in { get; set; }
        }
        /// <summary>
        /// 微信用户信息
        /// </summary>
        internal class WXUser
        {
            internal string openid { get; set; }
            internal string nickname { get; set; }
            internal string sex { get; set; }
            internal string province { get; set; }
            internal string city { get; set; }
            internal string country { get; set; }
            internal string headimgurl { get; set; }
            internal string privilege { get; set; }
            internal string unionid { get; set; }
        }
    }
}