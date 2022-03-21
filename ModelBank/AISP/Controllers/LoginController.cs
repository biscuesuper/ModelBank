using Microsoft.AspNetCore.Mvc;
using AISP.Models;
using System.Diagnostics;

namespace AISP.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public LoginController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([Bind] Login ad)
        {
            var res = Db.LoginCheck(ad);
            if (res == null)
            {
                TempData["msg"] = "Username or Password is wrong.!";
                return View();
            }
            return RedirectToAction("LoginSuccess", "Profile", new { id = res.Id, username = res.Username});
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
