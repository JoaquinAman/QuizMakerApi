using JetBrains.Annotations;

namespace Domain.Model
{
    public class User
    {
        public string UserId { [UsedImplicitly] get; set; } = null!;
        public string UserName { [UsedImplicitly] get; set; } = null!;
    }
}
