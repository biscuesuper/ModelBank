using AISP.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AISP.Controllers
{
    public class ProfileController : Controller
    {
        private static Login _user = new Login();
        private static string _resultsView = "";
        

        public IActionResult Index()
        {
            if (!string.IsNullOrEmpty(_user.Username))
                ViewData["Name"] = _user.Username;
            if (!string.IsNullOrEmpty(_resultsView))
                ViewBag.JsonData = JValue.Parse(_resultsView).ToString(Formatting.Indented).Replace("\r\n", "<br/>");
            return View();
        }

        public IActionResult LoginSuccess(int id, string username)
        {
            _user.Id = id;
            _user.Username = username;
            return RedirectToAction("Index");
        }

        public IActionResult GetAccount()
        {
            var result = Requests.GetAccount().Result;
            _resultsView = JsonConvert.SerializeObject(result);
            return RedirectToAction("Index");
        }

        public IActionResult GetAccountBalance()
        {
            var result = Requests.GetAccountBalance().Result;
            _resultsView = JsonConvert.SerializeObject(result);
            return RedirectToAction("Index");
        }

        public IActionResult GetAccountTxns()
        {
            var result = Requests.GetAccountTxns().Result;
            _resultsView = JsonConvert.SerializeObject(result);
            return RedirectToAction("Index");
        }

    }
}
