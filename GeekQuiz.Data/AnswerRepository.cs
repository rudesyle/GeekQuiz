using GeekQuiz.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using Dapper;
using Dapper.Mapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GeekQuiz.Data
{
    public sealed class AnswerRepository : ReadOnlyRepository<AnswerEntity>, IAnswerRepository
    {
        public IEnumerable<AnswerEntity> GetByQuestionId(int questionId)
        {
            return base.Connection.GetList<AnswerEntity>(new { QuestionId = questionId }); 
        }
    }
}
