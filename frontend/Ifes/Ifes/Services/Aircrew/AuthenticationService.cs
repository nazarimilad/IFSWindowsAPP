using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.Services.Aircrew
{
    public sealed class AuthenticationService
    {
        private static readonly Lazy<AuthenticationService> lazy = new Lazy<AuthenticationService>(() => new AuthenticationService());
        
        public static AuthenticationService Instance { get { return lazy.Value; } }

        private string _jwtToken = "";
        public string JwtToken
        {
            get { return _jwtToken; }
            private set { }
        }

        private AuthenticationService()
        {
        }

        public async Task<bool> LogIn(string email, string password)
        {
            if (email == "admin@test.com" && password == "admintest")
            {
                _jwtToken = "3lidj9092Nlijqdzlidj092NN09883H2qlijdqz";
                return true;
            }
            throw new ArgumentException("Invalid email or password.");
        }
    }
}
