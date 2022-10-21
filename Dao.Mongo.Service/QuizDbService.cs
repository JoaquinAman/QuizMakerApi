using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Dao.Mongo.Entity;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Mongo.Service
{
    public class QuizDbService
    {
        private readonly IMongoCollection<QuizDao> _quizCollection;
        public QuizDbService(IOptions<MongoDbSettings> mongoDBsettings)
        {
            MongoClient client = new(mongoDBsettings.Value.ConnectionString);
            IMongoDatabase database = client.GetDatabase(mongoDBsettings.Value.DatabaseName);
            _quizCollection = database.GetCollection<QuizDao>("quizzes");
        }

        public async Task<List<Quiz>> GetAsync()
        {
            List<QuizDao> quizDtOs = await _quizCollection.Find(_ => true).ToListAsync();
            return quizDtOs.ConvertAll(x => x.ToQuiz());
        }
    }
}
