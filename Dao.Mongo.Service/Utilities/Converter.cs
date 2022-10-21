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
                //UserName = "prueba"
            };
        }
    }
}
