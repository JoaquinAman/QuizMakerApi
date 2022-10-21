using Dao.Mongo.Interface;

namespace Dao.Mongo.Service
{
    public class MongoDbSettings : IMongoDbSettings
    {
        //public string ConnectionString { get { return "mongodb+srv://diego:contrasena@videoform.4ctniww.mongodb.net/?retryWrites=true&w=majority"; } set { } }
        //public string DatabaseName { get { return "videoForm"; } set { } }
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
    }
}
