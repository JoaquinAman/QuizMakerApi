using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Dao.Mongo.Entity
{
    public class QuestionDao
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
        [BsonElement("question")]
        public string Question { get; set; } = string.Empty;
    }
}
