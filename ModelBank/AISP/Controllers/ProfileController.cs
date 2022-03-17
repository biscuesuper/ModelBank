﻿using AISP.Models;
using Microsoft.AspNetCore.Mvc;

namespace AISP.Controllers
{
    public class ProfileController : Controller
    {
        private string modelBankUrl = "";

        private static Login _user = new Login();

        public IActionResult Profile(string? url)
        {
            if (!string.IsNullOrEmpty(_user.Username))
                ViewData["Name"] = _user.Username;
            if (!string.IsNullOrEmpty(url))
                ViewData["ModelBankUrl"] = url;
            return View();
        }

        public IActionResult LoginSuccess(int id, string username)
        {
            _user.Id = id;
            _user.Username = username;
            return RedirectToAction("Profile");
        }

        public IActionResult SelectedModelBank()
        {
            var consent = Db.CreateTestConsent();
            var consentResponse = Requests.PostAccessConsent(consent);
            // request consent
            // create link with consent id
            var url = "http://www.google.com";
            return RedirectToAction("Profile", new { url = url});
        }



        //public IActionResult GetAccount()
        //{
        //    var result = Requests.GetAccount().Result;
        //    _resultsView = JsonConvert.SerializeObject(result);
        //    return Index();
        //}

        //public IActionResult GetAccounts()
        //{
        //    var result = Requests.GetAccounts().Result;
        //    _resultsView = JsonConvert.SerializeObject(result);
        //    return Index();
        //}

        //public IActionResult GetAccountBalance()
        //{
        //    var result = Requests.GetAccountBalance().Result;
        //    _resultsView = JsonConvert.SerializeObject(result);
        //    return Index();
        //}

        //public IActionResult GetAccountTxns()
        //{
        //    var result = Requests.GetAccountTxns().Result;
        //    _resultsView = JsonConvert.SerializeObject(result);
        //    return Index();
        //}

