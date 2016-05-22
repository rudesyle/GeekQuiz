using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Description;
using GeekQuiz.Entities;
using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using GeekQuiz.Business;

namespace GeekQuiz.Controllers
{
    public class TriviaController : ApiController
    {
        private SampleData db = SampleData._instance;
        private QuestionBusiness _uow = new QuestionBusiness();

        // GET api/Trivia
        [ResponseType(typeof(TriviaQuestion))]
        public IHttpActionResult Get(int currentQuestionId=0)
        {
            var userId = "rudesyle"; // User.Identity.Name;

            var nextQuestion = this.NextQuestionAsync(userId, currentQuestionId);

            if (nextQuestion == null)
            {
                return this.NotFound();
            }

            return this.Ok(nextQuestion);
        }

        // POST api/Trivia
        [ResponseType(typeof(TriviaAnswer))]
        public IHttpActionResult Post(TriviaAnswer answer)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            answer.UserId = User.Identity.Name;

            var isCorrect = this.StoreAsync(answer);
            return this.Ok<bool>(isCorrect);
        }

        private QuestionEntity NextQuestionAsync(string userId,int currentQuestionId)
        {
            var questionsCount = _uow.GetAll().Count;
            var nextQuestionId = (currentQuestionId % questionsCount) + 1;
            return _uow.GetById(nextQuestionId);
        }

        private bool StoreAsync(TriviaAnswer answer)
        {
            this.db.db.TriviaAnswers.Add(answer);

            var selectedOption = this.db.db.TriviaQuestions.FirstOrDefault(x => x.Id == answer.QuestionId).Options.FirstOrDefault(x => x.Id == answer.OptionId);

            return selectedOption.IsCorrect;
        }
    }
}
