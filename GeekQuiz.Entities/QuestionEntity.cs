using Dapper;
using System.Collections.Generic;

namespace GeekQuiz.Entities
{
    [Table("TriviaQuestion")]
    public class QuestionEntity
    {
        public QuestionEntity() 
        {
            Answers = new List<AnswerEntity>();
        }

        [Key]
        public int QuestionId { get; set; }

        public string Title { get; set; }

        public List<AnswerEntity> Answers { get; set; }
    }
}
