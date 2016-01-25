using System.ServiceModel;

namespace BoooooJu.Service.Core.Contracts.Base
{ 
    [ServiceContract]
    public interface IBaseSetData<T> where T :class
    {
        [OperationContract]
        T Insert(T t);
        [OperationContract]
        bool DeleteByPrimaryKey(T t);
        [OperationContract]
        T Update(T t);
    }
}
