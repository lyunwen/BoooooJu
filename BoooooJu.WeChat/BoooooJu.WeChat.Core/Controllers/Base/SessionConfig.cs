using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.WeChat.Core.Controllers.Base
{
    /// <summary>
    /// 项目所有Session Key的取值
    /// </summary>
    public class SessionConfig
    {
        static SessionConfig()
        {
            var type = typeof(SessionConfig);
            var instance = Activator.CreateInstance(type);
            System.Reflection.PropertyInfo[] propertyInfos = type.GetProperties();
            foreach (var propertyInfo in propertyInfos)
            {
                propertyInfo.SetValue(instance, Guid.NewGuid().ToString());
            }
        }
        /// <summary>
        /// 项目登陆者
        /// </summary>
        public static string BoooooJuer { private set; get; }
    }
}
