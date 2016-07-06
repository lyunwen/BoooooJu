using System.Data;
using System.Data.SqlClient;

namespace BoooooJu.Web.Core.DB
{
    /// <summary>
    /// 查询
    /// </summary>
    internal class QueryDBHelper
    {
        private const string _SqlConnectionString = @"Data Source=120.24.185.131;Initial Catalog=BoooooJu;;user id=booooojuer;password=T23eW@nnn;MultipleActiveResultSets=True;";
        internal static IDbConnection OpenConnection()
        {
            SqlConnection conn = new SqlConnection(_SqlConnectionString);
            conn.Open();
            return conn;
        }
    }
}
