using AISP.Models;
using Microsoft.AspNetCore.Mvc;

namespace AISP.Controllers
{
    public class ProfileController : Controller
    {
        private static Login _user = new Login();
        

        public IActionResult Index()
        {
            if (!string.IsNullOrEmpty(_user.Username))
                ViewData["Name"] = _user.Username;
            return View();
        }

        public IActionResult LoginSuccess(int id, string username)
        {
            _user.Id = id;
            _user.Username = username;
            return RedirectToAction("Index");
        }

        

        //public IActionResult GetAccount()
        //{
        //    var result = Requests.GetAccount().Result;
        //    _resultsView = JsonConvert.SerializeObject(result);
        //    return Index();
        //}

        //public IActionResult GetAccounts()
        //{
        //    var result = Requests.GetAccounts().Result;
        //    _resultsView = JsonConvert.SerializeObject(result);
        //    return Index();
        //}

        //public IActionResult GetAccountBalance()
        //{
        //    var result = Requests.GetAccountBalance().Result;
        //    _resultsView = JsonConvert.SerializeObject(result);
        //    return Index();
        //}

        //public IActionResult GetAccountTxns()
        //{
        //    var result = Requests.GetAccountTxns().Result;
        //    _resultsView = JsonConvert.SerializeObject(result);
        //    return Index();
        //}

        //public IActionResult PostAccessConsents()
        //{
        //    var result = Requests.PostAccessConsents().Result;
        //    _resultsView = JsonConvert.SerializeObject(result);
        //    return Index();
        //}

        //public IActionResult GetAccessConsents()
        //{
        //    var result = Requests.GetAccessConsents().Result;
        //    _resultsView = JsonConvert.SerializeObject(result);
        //    return Index();
        //}

        //public IActionResult DeleteAccessConsents()
        //{
        //    var result = Requests.DeleteAccessConsent();
        //    _resultsView = result;
        //    return Index();
        //}
    }
}
