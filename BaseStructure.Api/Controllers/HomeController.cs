using BaseStructure.Api.Config;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BaseStructure.Api.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<DatabaseConfig> _settings;

        public HomeController(IOptions<DatabaseConfig> settings)
        {
            _settings = settings;
        }

        [HttpGet("test")]
        public IActionResult Index()
        {
            var s = _settings.Value.DatabaseName;
            return View();
        }
    }
}
