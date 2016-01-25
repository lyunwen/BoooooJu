using BoooooJu.Service.Core.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.Core.Contracts.Base
{
    [ServiceContract]
    public class BaseSetOperation<T>: IBaseDataSet<T> where T : class
    {
        [OperationContract]
        public T Insert(T t)
        {
            T result = null;
            if (t != null)
            {
                int i = 55;
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
                result = db.SaveChanges()>0;
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
