using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.DPCore.Base
{
    public interface IQuery
    {
        string ToWheres();
        string OrderBy { get; }
    }
}
