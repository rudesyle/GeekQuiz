using GeekQuiz.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekQuiz.Data
{
    public interface IAnswerRepository : IReadOnlyRepository<AnswerEntity>
    {
        IEnumerable<AnswerEntity> GetByQuestionId(int questionId);
    }
}
