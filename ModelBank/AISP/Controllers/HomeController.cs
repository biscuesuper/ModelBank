using AISP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using ModelBank.Objects;
using Newtonsoft.Json;
using ModelBank.Resources.Objects;
using ModelBank.Resources.Tests;

namespace AISP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private string _resultsView= "";

        private string url = "https://localhost:7259/open-banking/v1/aisp/Account";

        private static HttpClient _client = new HttpClient();

        private int testAccId = 1;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Serialisation.ReadXML();
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

        public IActionResult GetAccount()
        {
            _resultsView = "one account";
            HttpResponseMessage response = _client.GetAsync(url + $"/{testAccId}").Result;
            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsAsync<Account>().Result;
                //_resultsView = a.ToString();
                _resultsView = JsonConvert.SerializeObject(a);
            }
            return Index();
        }

        public IActionResult GetAccounts()
        {
            _resultsView = "more accounts";
            HttpResponseMessage response = _client.GetAsync(url + "/").Result;
            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsAsync<List<Account>>().Result;
                //_resultsView = a.ToString();
                _resultsView = JsonConvert.SerializeObject(a);
            }

            return Index();
        }

        public IActionResult GetAccountBalance()
        {
            _resultsView = "one account bal";
            HttpResponseMessage response = _client.GetAsync(url + $"/{testAccId}/balance").Result;
            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsAsync<decimal>().Result;
                //_resultsView = a.ToString();
                _resultsView = a.ToString();
            }
            return Index();
        }

        public IActionResult GetAccountTxns()
        {
            _resultsView = "one account txns";
            HttpResponseMessage response = _client.GetAsync(url + $"/{testAccId}/transactions").Result;
            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsAsync<List<Txn>>().Result;
                //_resultsView = a.ToString();
                _resultsView = JsonConvert.SerializeObject(a);
            }
            return Index();
        }
    }
}