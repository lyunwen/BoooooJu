using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;



namespace ServerWcfService.CustomValidators
{
    public class MyCustomValidator : UserNamePasswordValidator
    {
        /// <summary>
        /// Validates the user name and password combination.
        /// </summary>
        /// <param name="userName">The user name.</param>
        /// <param name="password">The password.</param>
        public override void Validate(string userName, string password)
        {
            // validate arguments
            if (string.IsNullOrEmpty(userName))
                throw new ArgumentNullException("userName");
            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException("password");
            // check if the user is not xiaozhuang
            if (userName != "xiaozhuang" || password != "123456")
                throw new SecurityTokenException("用户名或者密码错误！");
        }
    }

}