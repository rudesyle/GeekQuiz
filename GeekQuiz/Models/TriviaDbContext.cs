using Microsoft.Data.Entity;
using System.Collections.Generic;
using System.Data.Entity;

namespace GeekQuiz.Entities
{
    public class TriviaDbContext
    {
        
        public List<TriviaQuestion> TriviaQuestions { get; set; }

        public List<TriviaOption> TriviaOptions { get; set; }

        public List<TriviaAnswer> TriviaAnswers { get; set; }
    }
}
