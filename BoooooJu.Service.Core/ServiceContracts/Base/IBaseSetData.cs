using System.ServiceModel;

namespace BoooooJu.Service.Core.Contracts.Base
{ 
    [ServiceContract]
    public interface IBaseSetData<T> where T :class
    {
        [OperationContract]
        T Insert(T t);
        [OperationContract]
        bool DeleteByPrimaryKey(params object[] keyValues);
        [OperationContract]
        T UpdateByPrimaryKey(T t);
    }
}
