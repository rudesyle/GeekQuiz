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
    public abstract class Repository<T> :ReadOnlyRepository<T>, IRepository<T>
    {

        public virtual int? Insert(T entity)
        {
            return base.Connection.Insert(entity);
        }

        public virtual void Update(T entity)
        {
            base.Connection.Update(entity);
        }

        public virtual void Delete(T entity)
        {
            base.Connection.Delete(entity);
        }

        public override T GetByID(int id)
        {
            return Connection.Get<T>(id);
        }

        public override IEnumerable<T> GetAll()
        {
            return Connection.GetList<T>();
        }
    }
}