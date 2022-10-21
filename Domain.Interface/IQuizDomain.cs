using Domain.Model;
namespace Domain.Interface
{
    public interface IQuizDomain
    {
        Task<List<Quiz>> GetQuizzesAsync();
    }
}
