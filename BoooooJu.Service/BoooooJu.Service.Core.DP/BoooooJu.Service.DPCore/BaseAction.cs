using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.DPCore.Base
{
    public static class BaseAction<T> where T : class, new()
    {
        public static bool InsertEntities(string sql, IEnumerable<T> entities)
        {
            bool result = false;
            using (IDbConnection conn = DBHelper.OpenConnection())
            {
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        conn.Execute(sql, entities, trans, 30, CommandType.Text);
                        trans.Commit();
                        result = true;
                    }
                    catch
                    {
                        trans.Rollback();
                        return false;
                    }
                }
                return result;
            }
        }
        public static T Insert(string addSqlCmd, T addParam, string tableName, string id = "Id")
        {
            T tResult = null;
            string queryCmd = string.Format(@"SELECT * FROM [{0}] WHERE {1}=@Id", tableName, id);
            using (IDbConnection conn = DBHelper.OpenConnection())
            {
                int insertedId = conn.Query<int>(addSqlCmd, addParam).First();
                tResult = conn.Query<T>(queryCmd, new { Id = insertedId }).First();
            }
            return tResult;
        }
        public static T FindById(int id, string tableName, string returnFields = "*", string wheres = "")
        {
            T tResult = null;
            if (string.IsNullOrEmpty(wheres))
                wheres = " AND 1=1";
            string sqlCmdTest = string.Format(@"SELECT {0} FROM [{1}] WHERE Id=@Id {2}", returnFields, tableName, wheres);
            using (IDbConnection conn = DBHelper.OpenConnection())
            {
                tResult = conn.Query<T>(sqlCmdTest, new { Id = id }).FirstOrDefault();
            }
            return tResult;
        }
    }
}