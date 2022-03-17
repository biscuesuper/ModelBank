using Microsoft.AspNetCore.Mvc;
using ModelBank.Auth.Models;
using OBData.Objects;
using System.Diagnostics;

namespace ModelBank.Auth.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private string url = "https://localhost:7259/open-banking/v1/aisp";

        private static HttpClient _client = new HttpClient();

        private static string _consentId = "";

        public LoginController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult LoginConsent(string consentId)
        {
            _consentId = consentId;
            return RedirectToAction("Login");
        }

        [HttpPost]
        public IActionResult Login([Bind] Login ad)
        {
            var res = Db.LoginCheck(ad);
            if (res == null)
            {
                TempData["msg"] = "Username or Password is wrong!";
                return View();
            }
            else
            {
                HttpResponseMessage response = _client.GetAsync(url + $"/account-access-consents/{_consentId}/user-consent/{res.AccountId}").Result;
                if (response.IsSuccessStatusCode)
                {
                    var a = response.Content.ReadAsAsync<OBReadConsentResponse1>().Result;
                    return RedirectToAction("Success");
                }
                else
                {
                    TempData["msg"] = "Could not grant consent!";
                    return View();
                }
            }
            TempData["msg"] = "Something went wrong!";
            return View();
        }

        public IActionResult Success()
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
