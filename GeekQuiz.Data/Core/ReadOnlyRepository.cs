using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Dapper;
using System.Linq.Expressions;
using System.Data.SqlClient;
using GeekQuiz.Entities;
using System.Configuration;

namespace GeekQuiz.Data
{
    public abstract class ReadOnlyRepository<T> : IReadOnlyRepository<T>
    {
        internal IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["GeekQuiz"].ConnectionString);
            }
        }

        internal virtual dynamic Mapping(T item)
        {
            return item;
        }

        public virtual T GetByID(int id)
        {
            return Connection.Get<T>(id); 
        }

        /*public virtual IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> items = null;

            // extract the dynamic sql query and parameters from predicate
            QueryResult result = DynamicQuery.GetDynamicQuery(_tableName, predicate);

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                items = cn.Query<T>(result.Sql, (object)result.Param);
            }

            return items;
        }*/

        public virtual IEnumerable<T> GetAll()
        {
            return Connection.GetList<T>();
        }
    }
}