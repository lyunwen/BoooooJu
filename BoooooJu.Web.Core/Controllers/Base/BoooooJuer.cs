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
        ///// <summary>
        ///// 登入者帐户名
        ///// </summary>
        //public string AccountName { get; set; }
        /// <summary>
        /// 登入者昵称
        /// </summary>
        public string NikeName { get; set; }
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
        //[Remark("游客")]
        //Guest = 0,
        [Remark("角色A")]
        Agent = 1,
        [Remark("角色B")]
        Vendor = 2,
        [Remark("角色C")]
        Manager = 4,
        [Remark("角色D")]
        PermitD = 8,
        [Remark("角色E")]
        PermitE = 16,
        [Remark("角色F")]
        PermitF = 32,
        [Remark("角色G")]
        PermitG = 64,
        [Remark("管理员")]
        All = 127
    }
}
