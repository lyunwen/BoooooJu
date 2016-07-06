using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.DB.Aspects.Account.BOModels
{
    public class UserBO
    {
        public long Id { get; set; }
        public string NickName { get; set; }
        public string AccountName { get; set; }
        public string MobilePhone { get; set; }
        public ValidateEnum MobilePhoneValidate { get; set; }
        public string Password { get; set; }
    }
    public enum ValidateEnum
    {
        /// <summary>
        /// 未验证
        /// </summary>
        UnValidate = 1,
        /// <summary>
        /// 已验证
        /// </summary>
        Validated = 2,
    }
}
