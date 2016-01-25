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
            if (t != null)
            {
                using (BoooooJuDB db = new BoooooJuDB())
                {
                    db.Set<T>().Add(t);
                    db.SaveChanges();
                    result = t;
                }
            }
            return result;
        } 
        public bool DeleteByPrimaryKey(params object[] keyValues)
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
        public T UpdateByPrimaryKey(T t)
        {
            if (t != null)
            {
                using (BoooooJuDB db = new BoooooJuDB())
                {
                    if (db.Entry<T>(t).State == EntityState.Modified)
                    {
                        db.SaveChanges();
                    }
                    else if (db.Entry<T>(t).State == EntityState.Detached)
                    {
                        try
                        {
                            db.Set<T>().Attach(t);
                            db.Entry<T>(t).State = EntityState.Modified;
                        }
                        catch (InvalidOperationException)
                        {
                            T old = db.Set<T>().Find(t);
                            db.Entry(old).CurrentValues.SetValues(t);
                        }
                        db.SaveChanges();
                    }
                }
            }
            return t;
        }
    }
}
