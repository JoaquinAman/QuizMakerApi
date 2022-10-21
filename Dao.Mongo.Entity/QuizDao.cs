using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Text.Json.Serialization;


namespace Dao.Mongo.Entity
{
    [BsonIgnoreExtraElements]
    public class QuizDao
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
        [BsonElement("title")]
        public string Title { get; set; } = string.Empty;
        [BsonElement("questions")]
        [JsonPropertyName("questions")]
        public IList<QuestionDao> Questions { get; set; } = new List<QuestionDao>();
    }
}

