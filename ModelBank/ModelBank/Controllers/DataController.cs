using Microsoft.AspNetCore.Mvc;
using ModelBank.Library;
using OBData.Objects;

namespace ModelBank.Controllers
{
    [ApiController]
    // [participant-path-prefix]/open-banking/[version]/[resource-group]/[resource]/[resource-id]/[sub-resource]
    // https://superbank.com/apis/open-banking/v3.1/aisp/accounts/1234/transactions
    [Route("/open-banking/v1/aisp")] //[Route("[controller]")]
    public class DataController : Controller
    {
        private readonly ILogger<DataController> _logger;

        public DataController(ILogger<DataController> logger)
        {
            _logger = logger;
        }

        [HttpGet("accounts", Name = "GetAccounts")]
        public OBReadAccount6 GetAccounts(/*[FromHeader(Name = "Authorization")] string auth*/)
        {
            _logger.Log(LogLevel.Information, $"/");
            return new OBReadAccount6();
        }


        [HttpGet("accounts/{AccountId:int}", Name = "GetAccount")]
        public OBReadAccount6 GetAccount(/*[FromHeader(Name = "Authorization")] string auth,*/ [FromRoute] int AccountId)
        {
            _logger.Log(LogLevel.Information, $"/{AccountId}");
            var account = Db.GetAccount(AccountId);
            return account;
        }

        [HttpGet("balances", Name = "GetBalances")]
        public OBReadBalance1 GetBalances(/*[FromHeader(Name = "Authorization")] string auth*/)
        {
            _logger.Log(LogLevel.Information, $"/");
            return new OBReadBalance1();
        }

        [HttpGet("accounts/{AccountId:int}/balances", Name = "GetAccountBalances")]
        public OBReadBalance1 GetAccountBalances(/*[FromHeader(Name = "Authorization")] string auth,*/ [FromRoute] int AccountId)
        {
            _logger.Log(LogLevel.Information, $"/{AccountId}/balances");
            var balance = Db.GetBalance(AccountId);
            return new OBReadBalance1();
        }

        [HttpGet("transactions", Name = "GetTransactions")]
        public OBReadTransaction6 GetTransactions(/*[FromHeader(Name = "Authorization")] string auth*/)
        {
            _logger.Log(LogLevel.Information, $"/");
            return new OBReadTransaction6();
        }

        [HttpGet("accounts/{AccountId:int}/transactions", Name = "GetAccountTransactions")]
        public OBReadTransaction6 GetAccountTransactions(/*[FromHeader(Name = "Authorization")] string auth,*/ [FromRoute] int AccountId)
        {
            _logger.Log(LogLevel.Information, $"/{AccountId}/transactions");
            var txn = Db.GetTransaction(AccountId);
            return txn;
        }

    }
}
