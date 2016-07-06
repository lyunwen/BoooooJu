using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.DPCore.Base
{
    public class DefaultQuery : IQuery
    {
        public string OrderBy { get; private set; }

        public string Wheres { get; private set; }

        public string ToWheres()
        {
            throw new NotImplementedException();
        }
    }
}
