using System.Collections.Generic;
using System.ServiceModel;

namespace BoooooJu.Service.Core.Contracts.Base
{
    [ServiceContract]
    public interface IBaseGetData<T> where T : class
    { 
        [OperationContract]
        T GetDataByPrimaryKey(params object[] keyValues);
        [OperationContract]
        T GetDataByUniqueKey(string key);
        [OperationContract]
        List<T> GetDatasBy(QueryParameter.Base.IPage page);
    }
}
