using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.DPCore.Base
{
    public class SqlWhereTag
    {
        public SqlWhereTag()
        {
        }

        public SqlWhereTag SqlEQUALS(string sqlTagName, string value)
        {
            this._toWheres = string.Format("{0} AND {1}='{2}'", this._toWheres, sqlTagName.GetType().ToString(), value);
            return this;
        }

        public SqlWhereTag SqlEQUALS(int sqlTagName, string value)
        {
            this._toWheres = string.Format("{0} AND {1}={2}", _toWheres, sqlTagName.GetType().ToString(), value);
            return this;
        }

        public SqlWhereTag SqlIS(string sqlTagName, string value)
        {
            this._toWheres = string.Format("{0} AND {1} IS '{2}'", _toWheres, sqlTagName.GetType().ToString(), value);
            return this;
        }
        public SqlWhereTag SqlIS(int sqlTagName, string value)
        {
            this._toWheres = string.Format("{0} AND {1} IS {2}", _toWheres, sqlTagName.GetType().ToString(), value);
            return this;
        }
        public SqlWhereTag SqlIN(string sqlTagName, IEnumerable<string> values)
        {
            StringBuilder builder = new StringBuilder(values.Count());
            foreach (var item in values)
            {
                builder.AppendFormat("'{0}',", item);
            }
            this._toWheres = string.Format("{0} AND {1} IN ({2})", _toWheres, sqlTagName.GetType().ToString(), builder.ToString().TrimEnd(','));
            return this;
        }
        public SqlWhereTag SqlIN(int sqlTagName, IEnumerable<string> values)
        { 
            this._toWheres = string.Format("{0} AND {1} IN ({2})", _toWheres, sqlTagName.GetType().ToString(), string.Join(",", values));
            return this;
        }

        private string _toWheres = "1=1";
        public string ToWhere()
        {
            return _toWheres;
        }
    }
}
