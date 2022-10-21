

using Dao.Mongo.Interface;
using Domain.Interface;
using Domain.Model;

namespace Domain.Service
{
    public class QuizDomainService : IQuizDomain
    {
        private readonly IDatabase<Quiz> _database;

        public QuizDomainService(IDatabase<Quiz> database)
        {
            _database = database;
        }
        public async Task<List<Quiz>> GetQuizzesAsync()
        {
            return await _database.GetList();
        }
    }
}
