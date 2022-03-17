using AISP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json;
using OBData.Objects;
using OBData.Enums;

namespace AISP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private string _resultsView= "";


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (!string.IsNullOrEmpty(_resultsView))
            {
                ViewData["ResultsView"] = _resultsView;
            }
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult PostAccessConsents()
        {
            _resultsView = "post access token";

            var consent = new OBReadConsent1();
            consent.Data = new OBReadData1();
            consent.Data.Permissions = new List<string>();
            consent.Data.Permissions.Add(OBExternalPermissions1Code.ReadAccountsBasic.ToString());
            consent.Data.ExpirationDateTime = "2017-05-02T00:00:00+00:00";
            consent.Data.TransactionFromDateTime = "2017-05-03T00:00:00+00:00";
            consent.Data.TransactionToDateTime = "2017-12-03T00:00:00+00:00";
            consent.Risk = new OBRisk2();

            HttpResponseMessage response = _client.PostAsJsonAsync(urlbase + $"/account-access-consents", consent).Result;
            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsAsync<OBReadConsentResponse1>().Result;
                //_resultsView = a.ToString();
                _resultsView = JsonConvert.SerializeObject(a);
                _consentResponse = a;
            }
            return Index();
        }

        public IActionResult GetAccessConsents()
        {
            _resultsView = "get access token";
            var consentId = _consentResponse.Data.ConsentId;

            HttpResponseMessage response = _client.GetAsync(urlbase + $"/account-access-consents/{consentId}").Result;
            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsAsync<OBReadConsentResponse1>().Result;
                var status = a.Data.Status;
                _resultsView = status.ToString();
                //_resultsView = JsonConvert.SerializeObject(a);
                _consentResponse = a;
            }
            return Index();
        }

        public IActionResult DeleteAccessConsents()
        {
            _resultsView = "delete access token";
            var consentId = _consentResponse.Data.ConsentId;

            HttpResponseMessage response = _client.DeleteAsync(urlbase + $"/account-access-consents/{consentId}").Result;
            _resultsView = response.StatusCode.ToString();
            return Index();
        }
    }
}