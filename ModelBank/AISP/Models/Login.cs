using Microsoft.AspNetCore.Mvc;

namespace AISP.Models
{
    public class Login
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
