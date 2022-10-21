using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Dao.Mongo.Entity
{
    public class UserDao
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = null!;

        [BsonElement("username")]
        public string username { get; set; } = null!;
        [BsonElement("email")]
        public string email { get; set; } = null!;
        [BsonElement("token")]
        public string token { get; set; } = null!;
    }
}
