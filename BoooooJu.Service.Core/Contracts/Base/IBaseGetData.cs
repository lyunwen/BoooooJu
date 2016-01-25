using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.Core.Contracts.Base
{
    public interface IBaseDataGet<T> where T : class
    { 
        [OperationContract]
        T GetDataByPrimaryKey(int key);
        [OperationContract]
        T GetDataByUniqueKey(string key);
        [OperationContract]
        List<T> GetDatasBy(QueryParameter.Base.IPage page);
    }
}
