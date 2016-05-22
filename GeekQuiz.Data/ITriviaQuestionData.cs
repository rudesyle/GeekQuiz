using GeekQuiz.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekQuiz.Data
{
    public interface ITriviaQuestionData : IDisposable
    {
        IEnumerable<QuestionEntity> GetQuestions();
        QuestionEntity GetQuestionByID(int questionId);
        void InsertQuestion(QuestionEntity question);
        void DeleteQuestion(int question);
        void UpdateQuestion(QuestionEntity question);
        void Save();
    }
}
