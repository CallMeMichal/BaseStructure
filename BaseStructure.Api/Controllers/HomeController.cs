using BaseStructure.Api.Config;
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
        private readonly AppDbContext _appDbContext;

        public HomeController(IOptions<DatabaseConfig> settings, AppDbContext appDbContext)
        {
            _settings = settings;
            _appDbContext = appDbContext;
        }

        [HttpGet("test")]
        public IActionResult Index()
        {

            var databaseName = _settings.Value.DatabaseName; // Pobieranie wartości
            var user = _appDbContext.Users.FirstOrDefault();
            var test = "";

            return Ok(new { DatabaseName = databaseName }); // Zwracanie w odpowiedzi
        }
    }
}
