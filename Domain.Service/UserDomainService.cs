using Domain.Interface;
using Domain.Model;
using Dao.Mongo.Interface;

namespace Domain.Service
{
    public class UserDomainService : IUserDomain
    {
        private readonly IDatabase<User> _database;
        public UserDomainService(IDatabase<User> database)
        {
            _database = database;
        }
        public async Task<List<User>> GetUsersAsync()
        {
            return await _database.GetList();
        }
    }
}
