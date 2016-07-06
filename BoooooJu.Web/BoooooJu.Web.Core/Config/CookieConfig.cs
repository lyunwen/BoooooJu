using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.Config
{
    public class CookieConfig
    {
        public static CookieConfig Factory { get; private set; }
        static CookieConfig()
        {
            Factory = new CookieConfig();
        }
        private CookieConfig()
        {
            PropertyInfo[] properties = typeof(CookieConfig).GetProperties();
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
