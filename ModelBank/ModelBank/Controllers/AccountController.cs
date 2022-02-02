using Microsoft.AspNetCore.Mvc;
using ModelBank.Library;
using ModelBank.Objects;
using ModelBank.Resources.Objects;

namespace ModelBank.Controllers
{
    [ApiController]
    // [participant-path-prefix]/open-banking/[version]/[resource-group]/[resource]/[resource-id]/[sub-resource]
    // https://superbank.com/apis/open-banking/v3.1/aisp/accounts/1234/transactions
    [Route("/open-banking/v1/aisp/accounts")] //[Route("[controller]")]
    public class AccountController : Controller
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public AccountController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAccounts")]
        public Task<OBReadAccount6> GetAccounts([FromHeader(Name = "Authorization")] string auth)
        {
            _logger.Log(LogLevel.Information, $"/");
            return Db.GetAccountsAsync();
        }


        [HttpGet("{AccountId:int}", Name = "GetAccount")]
        public Task<Account?> GetAccount([FromHeader(Name = "Authorization")] string auth, [FromRoute] int AccountId)
        {
            _logger.Log(LogLevel.Information, $"/{AccountId}");
            return Db.GetAccountAsync(AccountId);
        }

        [HttpGet("{AccountId:int}/balances", Name = "GetAccountBalances")]
        public Task<decimal?> GetAccountBalances([FromHeader(Name = "Authorization")] string auth, [FromRoute] int AccountId)
        {
            _logger.Log(LogLevel.Information, $"/{AccountId}/balances");
            return Db.GetAccountBalancesAsync(AccountId);
        }

        [HttpGet("{AccountId:int}/transactions", Name = "GetAccountTxns")]
        public Task<IEnumerable<Txn>?> GetAccountTxns([FromHeader(Name = "Authorization")] string auth, [FromRoute] int AccountId)
        {
            _logger.Log(LogLevel.Information, $"/{AccountId}/transactions");
            return Db.GetAccountTxnsAsync(AccountId);
           
        }

    }
}
