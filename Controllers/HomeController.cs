using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using TestAppCore.DBAccess;
using TestAppCore.Models;

namespace TestAppCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly TestApplicatioCoreContext _dbcontext;

        private IMainRepositry _main;

        public HomeController(ILogger<HomeController> logger, TestApplicatioCoreContext dbcontext)
        {
            _logger = logger;
            _dbcontext = dbcontext;
        }



        public IActionResult Index()
        {
            _main = new MainServices(_dbcontext);
            var test = _main.GetAllUsers();
            return View();
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
