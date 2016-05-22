using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace GeekQuiz.Entities
{
    [Table("UsersAnswers")]
    public class UserAnswerEntity
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        public int AnswerId { get; set; }

    }
}
