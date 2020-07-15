using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.Services.Aircrew
{
    public sealed class LoginService
    {
        private static readonly Lazy<LoginService> lazy = new Lazy<LoginService>(() => new LoginService());
        
        public static LoginService Instance { get { return lazy.Value; } }

        private LoginService()
        {
        }

        public async Task<bool> LogIn(string email, string password)
        {
            if (email == "admin@test.com" && password == "admintest")
            {
                return true;
            }
            throw new ArgumentException("Invalid email or password.");
        }
    }
}
