using Microsoft.AspNetCore.Mvc;
using AISP.Models;

namespace AISP.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([Bind] Login ad)
        {
            int res = Db.LoginCheck(ad);
            if (res == 0)
            {
                TempData["msg"] = "Username or Password is wrong.!";
                return View();
            }
            return View();
        }
    }
}
