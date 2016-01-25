using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.ViewModels.Account
{
    public class SignInModel
    {
        //登入名（帐户名、手机号码、邮箱等）
        public string SignName { get; set; }
        
        public string Pswd { get; set; }
        //上次尝试登入时间
        public DateTime PreSignTime { get; set; } 
    }
}
