﻿using Microsoft.AspNetCore.Mvc;

namespace ModelBank.Auth.Models
{
    public class Login
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string AccountId { get; set; }

    }
}
