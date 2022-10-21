using Domain.Model;
namespace Interface
{
    public interface IQuizDomain
    {
        Task<List<Quiz>> GetQuizzesAsync();
    }
}
