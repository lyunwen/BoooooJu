using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.DPCore
{
    public class DBHelper
    {
        private const string _SqlConnectionString = @"Data Source=120.24.185.131;Initial Catalog=BoooooJu;;user id=booooojuer;password=T23eW@nnn;MultipleActiveResultSets=True;";
        public static IDbConnection OpenConnection()
        {
            SqlConnection conn = new SqlConnection(_SqlConnectionString);
            conn.Open();
            return conn;
        }
    }
}
