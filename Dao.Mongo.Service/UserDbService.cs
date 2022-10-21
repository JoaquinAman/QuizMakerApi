using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Dao.Mongo.Interface;
using Dao.Mongo.Entity;
using Dao.Mongo.Service.Utilities;
using Domain.Model;

namespace Dao.Mongo.Service
{
    public class UserDbService : IDatabase<User>
    {
        private readonly IMongoCollection<UserDao> _userCollection;
        public UserDbService(IOptions<MongoDbSettings> mongoDBsettings)
        {
            MongoClient client = new(mongoDBsettings.Value.ConnectionString);
            IMongoDatabase database = client.GetDatabase(mongoDBsettings.Value.DatabaseName);
            _userCollection = database.GetCollection<UserDao>("users");
        }
        public async Task<List<User>> GetList()
        {
            List<UserDao> userDaoList = await _userCollection.Find(_ => true).ToListAsync();
            return userDaoList.ConvertAll(x => x.ToUser()).ToList();
        }
    }
}
