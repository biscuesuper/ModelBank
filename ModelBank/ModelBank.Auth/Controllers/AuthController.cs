using Microsoft.AspNetCore.Mvc;
using ModelBank.Auth.Models;
using System.Diagnostics;

namespace ModelBank.Auth.Controllers
{
    public class AuthController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AuthController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Consent()
        {
            return View();
        }

        public IActionResult Accounts()
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
