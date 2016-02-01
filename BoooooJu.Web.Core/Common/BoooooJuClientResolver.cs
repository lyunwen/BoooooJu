using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoooooJu.Web.Core.SetUserService;
using System.ServiceModel.Description;
using BoooooJu.Web.Core.GetUserService;
using System.ServiceModel;

namespace BoooooJu.Web.Core.Common
{
    public class BoooooJuClientResolver<T> : ClientBase<T> where T : class
    {
        public BoooooJuClientResolver(T t)
        {
            var tt = t as ClientBase<T>;
            if (tt != null)
            {
                tt.ClientCredentials.UserName.UserName = "boooooju.com";
                tt.ClientCredentials.UserName.Password = "123456";
            }
            singleTon = t;
        }
        public T singleTon;
        public T Client
        {
            get
            {
                if (singleTon == null)
                {
                    throw new ArgumentNullException();
                }
                return singleTon;
            }
        }
    }
}