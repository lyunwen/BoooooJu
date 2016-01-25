using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.Core.Contracts.Base
{
    public interface IBaseDataGet<T> where T : class
    {
        T GetDataByPrimaryKey(int key);
        T GetDataByUniqueKey(string key);
        List<T> GetDatasBy(QueryParameter.Base.IPage page);
    }
}
