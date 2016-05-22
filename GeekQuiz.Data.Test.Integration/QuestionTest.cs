using System;
using Xunit;
using System.Linq;

namespace GeekQuiz.Data.Test.Integration
{
    public class QuestionTest
    {
        QuestionRepository _db = new QuestionRepository();

        [Fact]
        public void GetAll_WillReturn_Records()
        {
            Assert.True(_db.GetAll().ToList().Count > 0);
        }

        [Fact]
        public void GetById_WillReturn_Records()
        {
            Assert.True(_db.GetByID(1).QuestionId==1);
        }
    }
}
