﻿using BoooooJu.Web.Core.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BoooooJu.Web.Core.Controllers
{
    // [BoAuthorize(Base.BoooooJuPermit.All)]
    public class HomeController : Base.BoooooJuController
    {
        public  ActionResult Index()
        {  
            //SetUserService.SetUserClient client1 = new SetUserService.SetUserClient(); 
            //client1.ClientCredentials.UserName.UserName = "boooooju.com";
            // client1.ClientCredentials.UserName.Password = "123456";
            //client1.RegisterByAccountName(new SetUserService.User()
            //{
            //    NickName = "zaizaiyou",
            //    Sex = 2,
            //    CreateTime = DateTime.Now,
            //    Role = 0,
            //    Signature = "世界这么大" + new Random().Next(1000, 9999)
            //}, "lyw" + new Random().Next(100, 999), "qq123123"); 
            return View();
        }
        //private static bool ServerCertificateValidationCallback(
        //  object sender,
        //  X509Certificate certificate,
        //  X509Chain chain,
        //  SslPolicyErrors sslPolicyErrors)
        //{
        //    return true;
        //}
    }
}
