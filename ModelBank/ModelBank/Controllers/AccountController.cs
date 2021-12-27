using Microsoft.AspNetCore.Mvc;
using ModelBank.Library;
using ModelBank.Objects;

namespace ModelBank.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : Controller
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public AccountController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }


        [HttpGet("/GetAccount/{id}", Name = "GetAccount")]
        public Account? GetAccount([FromRoute] int id)
        {
            var res = Db.GetAccountAsync(id).Result;
            var acc = res;
            _logger.Log(LogLevel.Information, $"{acc.Id}, {acc.UserId}, {acc.Balance}");
            return res;
        }

        [HttpGet("/GetAccounts", Name = "GetAccounts")]
        public IEnumerable<Account>? GetAccounts()
        {
            var res = Db.GetAccountsAsync().Result;
            if(res != null) 
            { 
                var acc = res.FirstOrDefault();
                _logger.Log(LogLevel.Information, $"{acc.Id}, {acc.UserId}, {acc.Balance}");
            }
            return res.ToArray();
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
