using Interface;
using Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace QuizMakerApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly IQuizDomain _quizDomain;

        public QuizController(IQuizDomain quizDomain)
        {
            _quizDomain = quizDomain;
        }

        [HttpGet]
        public async Task<List<Quiz>> Get()
        {
            return await _quizDomain.GetQuizzesAsync();
        }
    }
}
