using System;
using Xunit;
using System.Linq;
using GeekQuiz.Entities;

namespace GeekQuiz.Data.Test.Integration
{
    public class UserAnswerTest : IDisposable
    {
        UserAnswerRepository _db = new UserAnswerRepository();
        UserAnswerEntity _userAnswer;

        public UserAnswerTest()
        {
            _userAnswer = new UserAnswerEntity() { UserId = 1, AnswerId = 1 };
            var newId = _db.Insert(_userAnswer);
            _userAnswer.Id = (int)newId;
        }

        public void Dispose()
        {
            _db.Delete(_userAnswer);
        }

        /*[Fact]
        public void GetAll_WillReturn_Records()
        {
            Assert.True(_db.GetAll().ToList().Count > 0);
        }*/

        [Fact]
        public void GetById_WillReturn_Records()
        {
            Assert.True(_db.GetByID(1).AnswerId==1);
        }
    }
}
