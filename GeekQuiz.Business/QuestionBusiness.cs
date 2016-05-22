using GeekQuiz.Data;
using GeekQuiz.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekQuiz.Business
{
    public class QuestionBusiness
    {
        IQuestionRepository _dbQuestions;
        IAnswerRepository _dbAnswers;

        public QuestionBusiness()
        {
            _dbQuestions = new QuestionRepository();
            _dbAnswers = new AnswerRepository();
        }

        public List<QuestionEntity> GetAll()
        {
            return _dbQuestions.GetAll().ToList();
        }

        public QuestionEntity GetById(int questionId)
        {
            var question = _dbQuestions.GetByID(questionId);
            question.Answers = _dbAnswers.GetByQuestionId(questionId).ToList();
            return question;
        }
    }
}
