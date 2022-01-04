using Microsoft.AspNetCore.Mvc;
using ModelBank.Library;
using ModelBank.Objects;

namespace ModelBank.Controllers
{
    [ApiController]
    // [participant-path-prefix]/open-banking/[version]/[resource-group]/[resource]/[resource-id]/[sub-resource]
    // https://superbank.com/apis/open-banking/v3.1/aisp/accounts/1234/transactions
    [Route("/open-banking/v1/aisp/[controller]")] //[Route("[controller]")]
    public class AccountController : Controller
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public AccountController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAccounts")]
        public IEnumerable<Account>? GetAccounts()
        {
            var res = Db.GetAccountsAsync().Result;
            if (res != null)
            {
                var acc = res.FirstOrDefault();
                _logger.Log(LogLevel.Information, $"{acc.Id.ToString()}, {acc.UserId.ToString()}, {acc.Balance.ToString()}");
            }
            return res.ToArray();
        }


        [HttpGet("{id}", Name = "GetAccount")]
        public Account? GetAccount([FromRoute] int id)
        {
            var res = Db.GetAccountAsync(id).Result;
            var acc = res;
            _logger.Log(LogLevel.Information, $"{acc.Id}, {acc.UserId}, {acc.Balance}");
            return res;
        }

        [HttpGet("{id}/balance", Name = "GetAccountBalance")]
        public decimal? GetAccountBalance([FromRoute] int id)
        {
            var res = Db.GetAccountAsync(id).Result;
            var acc = res;
            _logger.Log(LogLevel.Information, $"{acc.Id}, {acc.UserId}, {acc.Balance}");
            return res.Balance;
        }

        [HttpGet("{id}/transactions", Name = "GetAccountTxns")]
        public IEnumerable<Txn>? GetAccountTxns([FromRoute] int id)
        {
            var res = Db.GetAccountTxns(id).Result;
            var txn = res.FirstOrDefault();
            _logger.Log(LogLevel.Information, $"{txn.Id}, {txn.AccountId}, {txn.Amount}, {txn.Date}");
            return res;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
