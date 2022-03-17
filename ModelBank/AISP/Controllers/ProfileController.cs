using AISP.Models;
using Microsoft.AspNetCore.Mvc;

namespace AISP.Controllers
{
    public class ProfileController : Controller
    {
        private string modelBankUrl = "https://localhost:7073/Login/LoginConsent";

        private static Login _user = new Login();
        private static string _url = "";
        private static string _consentId = "";

        public IActionResult Profile()
        {
            if (!string.IsNullOrEmpty(_user.Username))
                ViewData["Name"] = _user.Username;
            if (!string.IsNullOrEmpty(_url))
                ViewData["ModelBankUrl"] = _url;
            return View();
        }

        public IActionResult LoginSuccess(int id, string username)
        {
            _user.Id = id;
            _user.Username = username;
            return RedirectToAction("Profile");
        }

        public IActionResult SelectedModelBank()
        {
            var consent = Db.CreateTestConsent();
            var consentResponse = Requests.PostAccessConsent(consent).Result;
            _consentId = consentResponse.Data.ConsentId;
            _url = $"{modelBankUrl}?consentId={_consentId}";
            return RedirectToAction("Profile");
        }

        public IActionResult LinkAccount()
        {
            var consent = Requests.GetAccessConsent(_consentId).Result;
            if(consent.Data.Status == OBData.Enums.OBExternalRequestStatus1Code.Authorised)
            {
                return RedirectToAction("ViewAccounts", "Accounts", new { user = _user, consentId = _consentId});
            }
            else
            {
                return RedirectToAction("Profile");
            }
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
