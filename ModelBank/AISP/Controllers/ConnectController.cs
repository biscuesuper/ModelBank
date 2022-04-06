using AISP.Models;
using Microsoft.AspNetCore.Mvc;

namespace AISP.Controllers
{
    public class ConnectController : Controller
    {
        private string modelBankUrl = "https://localhost:7073/Login/LoginConsent";
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SelectedModelBank()
        {
            var consent = Db.CreateTestConsent();
            var consentResponse = Requests.PostAccessConsent(consent)?.Result;
            var consentId = consentResponse?.Data.ConsentId;
            if (consentId == null) return RedirectToAction("Index");
            HttpContext.Session.SetString("ConsentId", consentId);
            HttpContext.Session.SetString("AuthServUrl", $"{modelBankUrl}?consentId={consentId}");
            HttpContext.Session.SetString("RedirectLinkAvail", "true");
            return RedirectToAction("Index");
        }

        public IActionResult LinkAccount()
        {
            var consentId = HttpContext.Session.GetString("ConsentId");
            var consent = Requests.GetAccessConsent(consentId)?.Result;
            HttpContext.Session.Remove("RedirectLinkAvail");
            if (consent?.Data.Status == OBData.Enums.OBExternalRequestStatus1Code.Authorised)
            {
                return RedirectToAction("Index", "Profile");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
