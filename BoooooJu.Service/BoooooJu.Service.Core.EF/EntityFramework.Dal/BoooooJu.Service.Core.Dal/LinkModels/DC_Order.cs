using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.Core.Dal
{
    public partial class DC_Order
    {
        public virtual DC_Food DC_Food { get; set; }

        public virtual DC_User DC_User { get; set; }
    }
}
