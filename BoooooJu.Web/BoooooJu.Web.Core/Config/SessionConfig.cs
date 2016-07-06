using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.Config
{
    public class SessionConfig
    {
        public static SessionConfig Factory { get; private set; }
        static SessionConfig()
        {
            Factory = new SessionConfig();
        }
        private SessionConfig()
        {
            PropertyInfo[] properties = typeof(SessionConfig).GetProperties();
            foreach (var item in properties)
            {
                if (item.CanWrite && item.PropertyType == typeof(string))
                {
                    item.SetValue(this, Guid.NewGuid().ToString().Replace("-", string.Empty), null);
                }
            }
        }

        public string TestName { get; private set; } 

        /// <summary>
        /// Url安全访问Code值
        /// </summary>
        public string SafeAccessCodeValue { get; private set; }

        /// <summary>
        /// 用户信息Cookie名称
        /// </summary>
        public string User { get; private set; }
         
    }
}
