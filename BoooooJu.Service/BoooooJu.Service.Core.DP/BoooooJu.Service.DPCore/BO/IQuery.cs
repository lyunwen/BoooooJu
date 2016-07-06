using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.DPCore.BO
{
    public interface IQuery
    {
        string OderBy { get; set; }
        string ToWhere();
    }
}
