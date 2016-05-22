using GeekQuiz.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GeekQuiz.Data
{
    public interface IReadOnlyRepository<T>
    {
        T GetByID(int id);
        //IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetAll();
    }
}
