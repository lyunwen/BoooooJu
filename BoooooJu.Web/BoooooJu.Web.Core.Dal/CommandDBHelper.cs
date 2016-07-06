using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.DB
{
    /// <summary>
    /// 命令
    /// </summary>
    internal class CommandDBHelper
    {
                                                                                 
        private const string _SqlConnectionString = @"data source =.; initial catalog = BoooooJu; user id = boooooju.commander; password=qq123123;MultipleActiveResultSets=True;";
        internal static IDbConnection OpenConnection()
        {
            SqlConnection conn = new SqlConnection(_SqlConnectionString);
            conn.Open();
            return conn;
        }
    }
}
