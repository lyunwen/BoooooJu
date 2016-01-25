using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.Core
{
    public interface IBaseDataSet<T>
    {
        T Insert(T t);
        bool DeleteByPrimaryKey(T t);
        T Update(T t);
    }
}
