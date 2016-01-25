using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.Core.Contracts.Base
{

    [ServiceContract]
    public interface IBaseDataSet<T>
    {
        [OperationContract]
        T Insert(T t);
        [OperationContract]
        bool DeleteByPrimaryKey(T t);
        [OperationContract]
        T Update(T t);
    }
}
