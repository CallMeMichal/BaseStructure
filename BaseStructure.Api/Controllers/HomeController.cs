using BaseStructure.Api.Config;
using BaseStructure.Application.Interface.Home;
using BaseStructure.Contracts.ModelsToApi.Request;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BaseStructure.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IOptions<DatabaseConfig> _settings;
        private readonly IHomeService _homeService;

        public HomeController(IOptions<DatabaseConfig> settings, IHomeService homeService)
        {
            _settings = settings;
            _homeService = homeService;
        }

        [HttpPost("test")]
        public async Task <IActionResult> Index([FromBody] LoginRequest request)
        {
            var users = await _homeService.GetUsers();

            return Ok(); // Zwracanie w odpowiedzi
        }
    }
}
