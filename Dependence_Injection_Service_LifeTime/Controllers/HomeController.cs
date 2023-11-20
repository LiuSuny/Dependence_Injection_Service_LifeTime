using Dependence_Injection_Service_LifeTime.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dependence_Injection_Service_LifeTime.Controllers
{
    public class HomeController : Controller
    {
        //To test our dependence injection and to see how it works we inplement private readonly for each service container
        
        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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