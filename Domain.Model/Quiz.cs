using JetBrains.Annotations;
namespace Domain.Model
{
    public class Quiz
    {
        public string QuizId { [UsedImplicitly] get; set; } = string.Empty;
        public string Title { [UsedImplicitly] get; set; } = string.Empty;
        public IList<Question> Questions { [UsedImplicitly] get; set; } = new List<Question>();
    }

}
