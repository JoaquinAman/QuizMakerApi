using JetBrains.Annotations;

namespace Domain.Model
{
    public class Question
    {
        public string QuestionId { [UsedImplicitly] get; set; } = string.Empty;
        public string StringQuestion { [UsedImplicitly] get; set; } = string.Empty;
    }
}
