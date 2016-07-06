using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Loger
{
    internal interface IResolver<T>
    {
        T Current { get; }
    }
}
