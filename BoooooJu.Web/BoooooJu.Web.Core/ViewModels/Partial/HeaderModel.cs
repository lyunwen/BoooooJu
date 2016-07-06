using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.ViewModels.Partial
{
    public class DefaultHeaderModel
    {
        public long Id { get; set; }
        public bool IsSign { get; set; }
        public string NickName { get; set; }
        /// <summary>
        /// 头部展现形式
        /// </summary>
        public int ShowStyle { get; set; }
    }
}