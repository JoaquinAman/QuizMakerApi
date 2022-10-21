using Microsoft.AspNetCore.Mvc;
using Domain.Interface;
using Domain.Model;

namespace QuizMakerApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserDomain _userDomain;
        public UserController(IUserDomain userDomain)
        {
            _userDomain = userDomain;
        }
        [HttpGet]
        [Route("/users")]
        public async Task<List<User>> GetUsers()
        {
            return await _userDomain.GetUsersAsync();
        }
    }
}
