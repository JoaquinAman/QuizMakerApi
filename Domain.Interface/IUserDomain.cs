using Domain.Model;

namespace Domain.Interface
{
    public interface IUserDomain
    {
        Task<List<User>> GetUsersAsync();
    }
}
