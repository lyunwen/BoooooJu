using System.Collections.Generic;
using System.ServiceModel;

namespace BoooooJu.Service.Core.Contracts.Base
{
    [ServiceContract]
    public interface IBaseGetData<T> where T : class
    { 
        [OperationContract]
        T GetDataByPrimaryKey(int key);
        [OperationContract]
        T GetDataByUniqueKey(string key);
        [OperationContract]
        List<T> GetDatas(QueryParameter.Page page);
    }
}
