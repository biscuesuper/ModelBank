using AISP.Models;
using Microsoft.AspNetCore.Mvc;

namespace AISP.Controllers
{
    public class ConnectController : Controller
    {
        private string modelBankUrl = "https://localhost:7073/Login/LoginConsent";
        private static string _url = "";
        private static string _consentId = "";
        public IActionResult Index()
        {
            if (!string.IsNullOrEmpty(_url))
            {
                ViewData["ModelBankUrl"] = _url;
                _url = "";
            }
            return View();
        }

        public IActionResult SelectedModelBank()
        {
            var consent = Db.CreateTestConsent();
            var consentResponse = Requests.PostAccessConsent(consent).Result;
            _consentId = consentResponse.Data.ConsentId;
            _url = $"{modelBankUrl}?consentId={_consentId}";
            return RedirectToAction("Index");
        }

        public IActionResult LinkAccount()
        {
            var consent = Requests.GetAccessConsent(_consentId).Result;
            if (consent.Data.Status == OBData.Enums.OBExternalRequestStatus1Code.Authorised)
            {
                return RedirectToAction("Index", "Profile", new { consentId = _consentId });
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
