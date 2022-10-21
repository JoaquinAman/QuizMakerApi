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
        internal static Quiz ToQuiz(this QuizDao input)
        {
            return new Quiz()
            {
                QuizId = input.Id,
                Title = input.Title,
                Questions = ToListQuestions(input.Questions)
            };
        }

        private static IList<Question> ToListQuestions(IList<QuestionDao> questions)
        {
            var list = new List<Question>();
            foreach (var item in questions)
            {
                list.Add(ToQuestion(item));
            }
            return list;
        }
    }
}
