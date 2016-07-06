using BoooooJu.Web.Core.Common;
using SuperWebSocket;
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
        public long Id { get; set; }
        /// <summary>
        /// 登入者昵称
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
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
        internal int Roles { get; set; }
        /// <summary>
        /// 用户消息Socket
        /// </summary>
        internal WebSocketSession Socket { get; set; }
    }
    public enum BoooooJuRole
    {
        [Remark("买家")]
        Buyer = 1,
        [Remark("经纪人")]
        Agent = 2,
        [Remark("卖主")]
        Vendor = 4,
        [Remark("管理员")]
        Diancan=16,
        [Remark("超级管理员")]
        SuperManager = 1024,
        [Remark("所有角色")]
        All = 1 + 2 + 4 + 8 + 1024,
    }
}
