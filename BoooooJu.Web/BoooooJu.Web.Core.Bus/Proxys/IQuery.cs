using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.Bus.Proxys
{
    public interface IQuery
    {
        string ToWhere();
        string OrderBy { get; set; }
    }
}
