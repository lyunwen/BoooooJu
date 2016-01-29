using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.Common
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class RemarkAttribute : Attribute
    {
        public RemarkAttribute(string remark)
        {
            Remark = remark;
        }
        public string Remark { private set; get; }
        public static string GetEnumRemark(Enum val)
        {
            Type type = val.GetType();
            FieldInfo fd = type.GetField(val.ToString());
            if (fd == null)
                return string.Empty;
            object[] attrs = fd.GetCustomAttributes(typeof(RemarkAttribute), false);
            string name = string.Empty;
            foreach (RemarkAttribute attr in attrs)
            {
                name = attr.Remark;
            }
            return name;
        }

        /// <summary>
        /// 获取enum注释键值对
        /// </summary>
        /// <param name="enumType"></param>
        /// <returns></returns>
        public static List<KeyValuePair<string, string>> GetNameValueList(Type enumType)
        {
            var keyValues = new List<KeyValuePair<string, string>>();
            Type type = enumType;
            FieldInfo[] fieldInfos = type.GetFields();
            foreach (var fieldInfo in fieldInfos)
            {
                var bar = fieldInfo.GetCustomAttribute(typeof(RemarkAttribute));
                if (bar != null)
                {
                    keyValues.Add(new KeyValuePair<string, string>(fieldInfo.Name, (bar as RemarkAttribute).Remark));
                }
            }
            return keyValues;
        }

        public static List<KeyValuePair<int, String>> GetKeyValueList(Type enumType)
        {
            Array arrs = Enum.GetValues(enumType);
            var keyValues = new List<KeyValuePair<int, String>>();
            return keyValues;
        }
    }
}
