using Dao.Mongo.Entity;
using Dao.Mongo.Interface;
using Dao.Mongo.Service.Utilities;
using Domain.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;


namespace Dao.Mongo.Service
{
    public class QuestionDbService : IDatabase<Question>
    {
        private readonly IMongoCollection<QuestionDao> _questionCollection;

        public QuestionDbService(IOptions<MongoDbSettings> mongoDBsettings)
        {
            MongoClient client = new(mongoDBsettings.Value.ConnectionString);
            IMongoDatabase database = client.GetDatabase(mongoDBsettings.Value.DatabaseName);
            _questionCollection = database.GetCollection<QuestionDao>("questions");
        }
        public async Task<List<Question>> GetList()
        {
            List<QuestionDao> questionDaoList = await _questionCollection.Find(_ => true).ToListAsync();
            return questionDaoList.ConvertAll(x => x.ToQuestion()).ToList();
        }
    }
}
