﻿using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
 
namespace BoooooJu.Service.ICore
{
    public class Validator_UserName : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName != "boooooju.com" || password != "123456")
                throw new SecurityTokenException("用户名或者密码错误！");
        }
    } 
}