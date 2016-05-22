using System;
using Xunit;
using System.Linq;

namespace GeekQuiz.Data.Test.Integration
{
    public class AnswerTest
    {
        AnswerRepository _db = new AnswerRepository();

        [Fact]
        public void GetAll_WillReturn_Records()
        {
            Assert.True(_db.GetAll().ToList().Count > 0);
        }

        [Fact]
        public void GetByQuestionId_WillReturn_Records()
        {
            Assert.True(_db.GetByQuestionId(1).FirstOrDefault().QuestionId==1);
        }
    }
}
