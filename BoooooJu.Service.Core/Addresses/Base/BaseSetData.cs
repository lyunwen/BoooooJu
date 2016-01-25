using BoooooJu.Service.Core.Contracts.Base;
using BoooooJu.Service.Core.Dal;
using System.ServiceModel;

namespace BoooooJu.Service.Core.Addresses.Base
{
    public class BaseSetOperation<T> : IBaseDataSet<T> where T : class
    {
        [OperationContract]
        public T Insert(T t)
        {
            T result = null;
            if (t != null)
            {
                using (BoooooJuDB db = new BoooooJuDB())
                {
                    db.Entry<T>(t).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                    result = t;
                }
            }
            return result;
        }
        [OperationContract]
        public bool DeleteByPrimaryKey(T t)
        {
            bool result = false;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                db.Entry<T>(t).State = System.Data.Entity.EntityState.Deleted;
                result = db.SaveChanges() > 0;
            }
            return result;
        }
        [OperationContract]
        public T Update(T t)
        {
            T result = null;
            if (t != null)
            {
                using (BoooooJuDB db = new BoooooJuDB())
                {
                    db.Entry<T>(t).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    result = t;
                }
            }
            return result;
        }
    }
}
