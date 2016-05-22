using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace GeekQuiz.Entities
{
    [Table("UserAnswers")]
    public class UserAnswerEntity
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }

        public int AnswerId { get; set; }

        public int QuestionId { get; set; }

    }
}
