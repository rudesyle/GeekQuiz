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
    public sealed class QuestionRepository : ReadOnlyRepository<QuestionEntity>, IQuestionRepository
    {
        /*public override IEnumerable<QuestionEntity> GetAll()
        {
            using (this.Connection)
            {
                var sql = @"select * from TriviaQuestion 
inner join TriviaAnswer on TriviaQuestion.QuestionId = TriviaAnswer.QuestionId";
                return this.Connection.Query<QuestionEntity, TriviaAnswerEntity, QuestionEntity>(sql,
                    (q, a) =>
                    {
                        q.Answers.Add(a);
                        return q;
                    }, splitOn: "QuestionId").ToList();
            }*/
    }
}
