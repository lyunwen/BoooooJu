using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.Core.Dal
{
    public partial class User
    { 
        public virtual ICollection<UserKey> UserKeys { get; set; }
    }
}
