using System;
using System.Linq;
using System.Collections.Generic;
using BoooooJu.Service.Core.Contracts.Base;
using BoooooJu.Service.Core.QueryParameter.Base;
using BoooooJu.Service.Core.Dal;
using System.ServiceModel;
using BoooooJu.Service.Core.QueryParameter;

namespace BoooooJu.Service.Core.Addresses.Base
{
    public abstract class BaseGetData<T> : IBaseGetData<T> where T : class
    {
        public T GetDataByPrimaryKey(int key)
        {
            T result = null;
            using (BoooooJuDB db = new BoooooJuDB())
            {
                result = db.Set<T>().Find(key);
            }
            return result;
        }

        public T GetDataByUniqueKey(string key)
        {
            throw new NotImplementedException();
        } 

        public List<T> GetDatas(Page page)
        {
            List<T> result = null;
            if (page == null)
                return result;

            using (BoooooJuDB db = new BoooooJuDB())
            {
                result = db.Set<T>().Skip((page.PageIndex - 1) * page.PageSize).Take(page.PageSize).ToList();
            }
            return result;
        }
    }
}
