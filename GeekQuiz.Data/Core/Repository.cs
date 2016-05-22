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
    public abstract class Repository<T> : ReadOnlyRepository<T>,IRepository<T>
    {

        public int? Insert(T entity)
        {
            return base.Connection.Insert(entity);
        }

        public void Update(T entity)
        {
            base.Connection.Update(entity);
        }

        public void Delete<t>(int id)
        {
            base.Connection.Delete(id);
        }

        public new T GetByID(int id)
        {
            return base.GetByID(id);
        }

        public new IEnumerable<T> GetAll()
        {
            return base.GetAll();
        }
    }
}