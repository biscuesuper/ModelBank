using Microsoft.AspNetCore.Mvc;
using ModelBank.Auth.Models;
using ModelBank.Resources.Objects;
using System.Diagnostics;

namespace ModelBank.Auth.Controllers
{
    public class AuthController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private string url = "https://localhost:7259/open-banking/v1/aisp";

        private static HttpClient _client = new HttpClient();

        public AuthController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Consent()
        {
            var testConsentId = "new-test-consent-id";
            HttpResponseMessage response = _client.GetAsync(url + $"/account-access-consents/{testConsentId}/user-consent").Result;
            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsAsync<OBReadConsentResponse1>().Result;
                //_resultsView = a.ToString();
            }
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
