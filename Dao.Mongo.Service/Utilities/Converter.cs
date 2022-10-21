using Dao.Mongo.Entity;
using Domain.Model;

namespace Dao.Mongo.Service.Utilities
{
    internal static class Converter
    {
        internal static User ToUser(this UserDao input)
        {
            return new User()
            {
                UserId = input.Id,
                UserName = input.username
            };
        }
        internal static Question ToQuestion(this QuestionDao input)
        {
            return new Question()
            {
                QuestionId = input.Id,
                StringQuestion = input.Question
            };
        }
    }
}
