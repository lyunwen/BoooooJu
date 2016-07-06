using BoooooJu.Service.Core.Contracts.Base;
using BoooooJu.Service.Core.Dal;
using System;
using System.Data.Entity;
using System.ServiceModel;

namespace BoooooJu.Service.Core.Addresses.Base
{
    public class BaseSetData<T> : IBaseSetData<T> where T : class
    {
        public T Insert(T t)
        {
            T result = null;
            try
            {
                if (t != null)
                {
                    using (BoooooJuDB db = new BoooooJuDB())
                    {
                        db.Entry(t).State = EntityState.Added;
                        db.SaveChanges();
                        result = t;
                    }
                }
                return result;
            }
            catch
            {
                return null;
            }
        }
        public bool DeleteByPrimaryKey(params object[] keyValues)
        {
            try
            {
                using (BoooooJuDB db = new BoooooJuDB())
                {
                    T model = db.Set<T>().Find(keyValues);
                    if (model != null)
                    {
                        db.Set<T>().Remove(model);
                        db.SaveChanges();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public T UpdateByPrimaryKey(T t)
        {
            if (t != null)
            {
                using (BoooooJuDB db = new BoooooJuDB())
                {
                    db.Entry(t).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            return t;
        }
    }
}