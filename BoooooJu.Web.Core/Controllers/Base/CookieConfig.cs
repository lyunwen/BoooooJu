using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.Controllers.Base
{
    /// <summary>
    /// 项目所有Cookie Key的取值
    /// </summary>
    public class CookieConfig
    {
        static CookieConfig()
        {
            var type = typeof(CookieConfig);
            var instance = Activator.CreateInstance(type);
            System.Reflection.PropertyInfo[] propertyInfos = type.GetProperties();
            foreach (var propertyInfo in propertyInfos)
            {
                propertyInfo.SetValue(instance, Guid.NewGuid().ToString());
            }
        }
    }
}
