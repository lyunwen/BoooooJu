using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.Dal.DBModels
{
    public class User_Statistics
    {
        public long Id { get; set; }

        public int UserId { get; set; }

        public int LoginOnCounts { get; set; }

        public int OnlineMinutes { get; set; }
    }
}
