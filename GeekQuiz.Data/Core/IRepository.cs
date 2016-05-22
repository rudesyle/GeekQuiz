using GeekQuiz.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GeekQuiz.Data
{
    public interface IRepository<T> : IReadOnlyRepository<T>
    {
        int? Insert(T entity);
        void Update(T entity);
        void Delete<t>(int id);
    }
}
