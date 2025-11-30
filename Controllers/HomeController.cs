using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestAppCore.BusinessLayer;
using TestAppCore.Models;

namespace TestAppCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMainService _mainService;

        public HomeController(ILogger<HomeController> logger, MainServices mainServices)
        {
            _logger = logger;
            _mainService = mainServices;
        }

        public IActionResult Index()
        {
            var test = _mainService.GetAllUsers();
            return View(test);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
