using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OBData.Enums;
using OBData.Objects;

namespace AISP.Models
{
    public static class Requests
    {
        private static string url = "https://localhost:7259/open-banking/v1/aisp/accounts";

        private static string urlbase = "https://localhost:7259/open-banking/v1/aisp";

        private static HttpClient _client = new HttpClient();

        private static string testAccId = "22289";

        public static Task<OBReadAccount6>? GetAccount()
        {
            HttpResponseMessage response = _client.GetAsync(url + $"/{testAccId}").Result;
            return response.IsSuccessStatusCode ? response.Content.ReadAsAsync<OBReadAccount6>() : null;
        }

        public static Task<OBReadAccount6>? GetAccounts()
        {
            HttpResponseMessage response = _client.GetAsync(url + "/").Result;
            return response.IsSuccessStatusCode ? response.Content.ReadAsAsync<OBReadAccount6>() : null;
        }

        public static Task<OBReadBalance1>? GetAccountBalance()
        {
            HttpResponseMessage response = _client.GetAsync(url + $"/{testAccId}/balance").Result;
            return response.IsSuccessStatusCode ? response.Content.ReadAsAsync<OBReadBalance1>() : null;
        }

        public static Task<OBReadTransaction6>? GetAccountTxns()
        {
            HttpResponseMessage response = _client.GetAsync(url + $"/{testAccId}/transactions").Result;
            return response.IsSuccessStatusCode ? response.Content.ReadAsAsync<OBReadTransaction6>() : null;
        }
