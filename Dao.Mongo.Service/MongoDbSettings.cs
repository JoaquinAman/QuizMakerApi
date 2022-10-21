using Dao.Mongo.Interface;

namespace Dao.Mongo.Service
{
    public class MongoDbSettings : IMongoDbSettings
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
    }
}
