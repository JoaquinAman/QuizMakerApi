using Dao.Mongo.Interface;
using Domain.Interface;
using Domain.Model;

namespace Domain.Service
{
    public class QuestionDomainService : IQuestionDomain
    {
        private readonly IDatabase<Question> _database;

        public QuestionDomainService(IDatabase<Question> database)
        {
            _database = database;
        }

        public async Task<List<Question>> GetQuestionAsync()
        {
            return await _database.GetList();
        }
    }
}
