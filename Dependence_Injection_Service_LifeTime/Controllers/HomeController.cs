using Dependence_Injection_Service_LifeTime.Models;
using Dependence_Injection_Service_LifeTime.Serveices;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace Dependence_Injection_Service_LifeTime.Controllers
{
    public class HomeController : Controller
    {
        //To test our dependence injection and to see how it works we inplement private readonly for each service container

        private readonly ITransientServce _Transient1;
        private readonly ITransientServce _Transient2;

        private readonly IScopedService  _Scoped1;
        private readonly IScopedService  _Scoped2;

        private readonly ISingletonService  _Singleton1;
        private readonly ISingletonService _Singleton2;

        //In our home controller constructor we implement and call on Interface services
        public HomeController(ITransientServce _transient1,
           ITransientServce _transient2, IScopedService _scoped1,
           IScopedService _scoped2, ISingletonService _singleton1,
           ISingletonService _singleton2)
        {
            _Transient1 = _transient1;
            _Transient2 = _transient2;
            _Scoped1 = _scoped1;
            _Scoped2 = _scoped2;
            _Singleton1 = _singleton1;
            _Singleton2 = _singleton2;
        }

        public IActionResult Index()
        {
            StringBuilder message = new StringBuilder();
            message.Append($"Transient 1: {_Transient1.GetService()}\n");
            message.Append($"Transient 2: {_Transient2.GetService()}\n\n");

            message.Append($"Scoped 1: {_Scoped1.GetService()}\n");
            message.Append($"Scoped 2: {_Scoped2.GetService()}\n\n");

            message.Append($"Singleton 1: {_Singleton1.GetService()}\n");
            message.Append($"Singleton 2: {_Singleton2.GetService()}\n\n");
            return Ok(message.ToString());
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