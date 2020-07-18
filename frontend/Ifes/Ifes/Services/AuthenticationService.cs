using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.Services
{
    public sealed class AuthenticationService
    {
        private static readonly Lazy<AuthenticationService> lazy = new Lazy<AuthenticationService>(() => new AuthenticationService());
        
        public static AuthenticationService Instance { get { return lazy.Value; } }

        public string JwtToken { get; private set; } = "";

        private AuthenticationService()
        {
        }

        public async Task<bool> LogIn(string email, string password)
        {
            if (email.ToLower() == "admin@test.com" && password == "admintest")
            {
                JwtToken = "3lidj9092Nlijqdzlidj092NN09883H2qlijdqz";
                return true;
            }
            throw new ArgumentException("Invalid email or password.");
        }

        public async Task<bool> LogIn(string reservationNumber)
        {
            if (reservationNumber.ToLower() == "abc123")
            {
                JwtToken = "3lidj9092Nlijqdfcidj092NN09883H2qlijdqz";
                return true;
            }
            throw new ArgumentException("Invalid reservation number.");
        }

        public void LogOut()
        {
            JwtToken = "";
        }
    }
}
