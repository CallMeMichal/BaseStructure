using BaseStructure.Api.Config;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BaseStructure.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IOptions<DatabaseConfig> _settings;

        public HomeController(IOptions<DatabaseConfig> settings)
        {
            _settings = settings;
        }

        [HttpGet("test")]
        public IActionResult Index()
        {
            var databaseName = _settings.Value.DatabaseName; // Pobieranie wartości
            return Ok(new { DatabaseName = databaseName }); // Zwracanie w odpowiedzi
        }
    }
}
