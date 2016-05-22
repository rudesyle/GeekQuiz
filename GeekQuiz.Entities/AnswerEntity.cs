using Dapper;

namespace GeekQuiz.Entities
{
    [Table("TriviaAnswer")]
    public class AnswerEntity 
    {
        [Key,Column("AnswerId")]
        public int Id { get; set; }

        public string Title { get; set; }

        public int QuestionId { get; set; }

        public bool IsCorrect { get; set; }
    }
}
