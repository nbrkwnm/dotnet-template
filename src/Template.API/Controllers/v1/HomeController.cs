using Microsoft.AspNetCore.Mvc;

namespace Template.API.Controllers.v1
{
    [ApiController]
    [Route("v1/[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<Controller> _logger;

        public HomeController(ILogger<Controller> logger)
        {
            _logger = logger;
        }

        [Route("/index")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
