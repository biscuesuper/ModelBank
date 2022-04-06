using AISP.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AISP.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index(string? data)
        {
            if (HttpContext.Session.TryGetValue("DisplayData", out var a))
                ViewBag.Data = JValue.Parse(data).ToString(Formatting.Indented).Replace("\r\n", "<br/>");
            return View();
        }

        public IActionResult LoginSuccess(int id, string username)
        {
            HttpContext.Session.SetInt32("UserId", id);
            HttpContext.Session.SetString("Username", username);
            HttpContext.Session.SetString("IsUserLoggedIn", "true");
        
            return RedirectToAction("Index");
        }

        public IActionResult GetAccount()
        {
            HttpContext.Session.SetString("DisplayData", "true");
            var result = Requests.GetAccount()?.Result;
            return RedirectToAction("Index", new { data = JsonConvert.SerializeObject(result) });
        }

        public IActionResult GetAccountBalance()
        {
            HttpContext.Session.SetString("SessionData", "true");
            var result = Requests.GetAccountBalance()?.Result;
            return RedirectToAction("Index", new { data = JsonConvert.SerializeObject(result) });
        }

        public IActionResult GetAccountTxns()
        {
            HttpContext.Session.SetString("SessionData", "true");
            var result = Requests.GetAccountTxns()?.Result;
            return RedirectToAction("Index", new { data = JsonConvert.SerializeObject(result) });
        }

    }
}
