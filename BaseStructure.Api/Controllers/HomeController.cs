using BaseStructure.Api.Config;
using BaseStructure.Application.Service.Home;
using BaseStructure.Infrastructure.DatabaseModels.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BaseStructure.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IOptions<DatabaseConfig> _settings;
        private readonly HomeService _homeService;

        public HomeController(IOptions<DatabaseConfig> settings, HomeService homeService)
        {
            _settings = settings;
            _homeService = homeService;
        }

        [HttpGet("test")]
        public async Task <IActionResult> Index()
        {
            var users = await _homeService.GetUsers();

            return Ok(); // Zwracanie w odpowiedzi
        }
    }
}
