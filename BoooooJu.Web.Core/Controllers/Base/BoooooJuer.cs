using BoooooJu.Web.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.Controllers.Base
{
    public partial class BoooooJuer
    {
        /// <summary>
        /// 登入者主键
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 登入者昵称
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// 登入时间
        /// </summary>
        public DateTime Logon { get; set; }
        /// <summary>
        /// 登入Ip
        /// </summary>
        public string LogonIp { get; set; }
        /// <summary>
        /// 用户权限 type:BoooooJuPermit
        /// </summary>
        internal int Permits { get; set; }
        /// <summary>
        /// 是否是超级管理员
        /// </summary>
        internal bool IsSuperAdmin { get; set; }
     
    }
    public enum BoooooJuPermit
    {
        [Remark("买家")]
        Buyer = 1,
        [Remark("经纪人")]
        Agent = 2,
        [Remark("卖主")]
        Vendor = 4,
        [Remark("管理员")]
        Manager = 127
    }
}
