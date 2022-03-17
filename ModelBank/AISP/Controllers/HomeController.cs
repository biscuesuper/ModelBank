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

    }
}