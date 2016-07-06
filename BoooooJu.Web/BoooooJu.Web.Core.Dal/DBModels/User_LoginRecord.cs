using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.Dal.DBModels
{
    public partial class User_LoginRecord
    {
        public long Id { get; set; }

        public long UserId { get; set; }

        public DateTime LoginTime { get; set; }

        public string LoginIp { get; set; }

        public string Equipment { get; set; }
    }
}
