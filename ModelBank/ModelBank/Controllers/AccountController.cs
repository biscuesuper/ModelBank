using Microsoft.AspNetCore.Mvc;
using ModelBank.Library;
using OBData.Objects;

namespace ModelBank.Controllers
{
    [ApiController]
    // [participant-path-prefix]/open-banking/[version]/[resource-group]/[resource]/[resource-id]/[sub-resource]
    // https://superbank.com/apis/open-banking/v3.1/aisp/accounts/1234/transactions
    [Route("/open-banking/v1/aisp/accounts")] //[Route("[controller]")]
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAccounts")]
        public OBReadAccount6 GetAccounts([FromHeader(Name = "Authorization")] string auth)
        {
            _logger.Log(LogLevel.Information, $"/");
            return new OBReadAccount6();
        }


        [HttpGet("{AccountId:int}", Name = "GetAccount")]
        public OBReadAccount6 GetAccount(/*[FromHeader(Name = "Authorization")] string auth,*/ [FromRoute] int AccountId)
        {
            _logger.Log(LogLevel.Information, $"/{AccountId}");
            var account = Db.GetAccountAsync(AccountId);
            return account;
        }

        [HttpGet("{AccountId:int}/balances", Name = "GetAccountBalances")]
        public OBReadBalance1 GetAccountBalances([FromHeader(Name = "Authorization")] string auth, [FromRoute] int AccountId)
        {
            _logger.Log(LogLevel.Information, $"/{AccountId}/balances");
            return new OBReadBalance1();
        }

        [HttpGet("{AccountId:int}/transactions", Name = "GetAccountTxns")]
        public OBReadTransaction6 GetAccountTxns([FromHeader(Name = "Authorization")] string auth, [FromRoute] int AccountId)
        {
            _logger.Log(LogLevel.Information, $"/{AccountId}/transactions");
            return new OBReadTransaction6();
        }

    }
}
