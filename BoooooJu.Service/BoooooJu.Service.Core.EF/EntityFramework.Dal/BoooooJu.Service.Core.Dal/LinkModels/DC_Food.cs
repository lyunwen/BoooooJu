using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.Core.Dal
{
    public partial class DC_Food
    {
        public virtual ICollection<DC_Order> DC_Orders { get; set; }
    }
}
