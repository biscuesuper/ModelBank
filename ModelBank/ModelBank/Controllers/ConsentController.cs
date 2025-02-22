﻿using Microsoft.AspNetCore.Mvc;
using ModelBank.Library;
using OBData.Objects;

namespace ModelBank.Resources.Controllers
{
    [ApiController]
    [Route("/open-banking/v1/aisp/account-access-consents")] 
    public class ConsentController : Controller
    {

        private readonly ILogger<ConsentController> _logger;

        public ConsentController(ILogger<ConsentController> logger)
        {
            _logger = logger;
        }


        [HttpPost(Name = "PostAccessConsent")]
        public OBReadConsentResponse1 PostAccessConsent(/*[FromHeader(Name = "Authorization")] string auth,*/ [FromBody] OBReadConsent1 consent)
        {
            _logger.Log(LogLevel.Information, $"/account-access-consents");
            return Db.PostAccessConsent(consent);
        }

        [HttpGet("{ConsentId}", Name = "GetAccessConsent")]
        public OBReadConsentResponse1 GetAccessConsent(/*[FromHeader(Name = "Authorization")] string auth,*/ [FromRoute] string ConsentId)
        {
            _logger.Log(LogLevel.Information, $"/account-access-consents/{ConsentId}");
            return Db.GetConsentResponse(ConsentId);
        }

        [HttpGet("{ConsentId}/user-consent/{AccountId}", Name = "GetUserAccessConsent")]
        public OBReadConsentResponse1 GetUserAccessConsent(/*[FromHeader(Name = "Authorization")] string auth,*/ [FromRoute] string ConsentId, [FromRoute] string AccountId)
        {
            _logger.Log(LogLevel.Information, $"/account-access-consents/{ConsentId}/user-consent/{AccountId}");
            return Db.UserConsentResponse(ConsentId, AccountId);
        }

        [HttpDelete("{ConsentId}", Name = "DeleteAccessConsent")]
        public void DeleteAccessConsent(/*[FromHeader(Name = "Authorization")] string auth,*/ [FromRoute] string ConsentId)
        {
            _logger.Log(LogLevel.Information, $"/account-access-consents/{ConsentId}");
        }

       
    }
}
