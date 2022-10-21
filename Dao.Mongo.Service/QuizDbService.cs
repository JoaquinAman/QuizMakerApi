using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Dao.Mongo.Entity;
using Domain.Model;
using Dao.Mongo.Service.Utilities;
using Dao.Mongo.Interface;

namespace Dao.Mongo.Service
{
    public class QuizDbService : IDatabase<Quiz>
    {
        private readonly IMongoCollection<QuizDao> _quizCollection;
        public QuizDbService(IOptions<MongoDbSettings> mongoDBsettings)
        {
            MongoClient client = new(mongoDBsettings.Value.ConnectionString);
            IMongoDatabase database = client.GetDatabase(mongoDBsettings.Value.DatabaseName);
            _quizCollection = database.GetCollection<QuizDao>("quizzes");
        }

        public async Task<List<Quiz>> GetList()
        {
            List<QuizDao> quizDaos = await _quizCollection.Find(_ => true).ToListAsync();
            return quizDaos.ConvertAll(x => x.ToQuiz());
        }
    }
}
