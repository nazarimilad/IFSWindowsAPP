using ifes.lib.domain.Users;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifes.Controllers.Helpers {
    public static class TokenHelper {
        public static String GetToken(ApplicationUser user) {
            var utcNow = DateTime.UtcNow;
            //todo Put jwt tokenstring in secure place
            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("0123456789123456789"));
            var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);



            var jwt = new JwtSecurityToken(
                signingCredentials: signingCredentials,

                notBefore: utcNow,

                expires: utcNow.AddSeconds(3600)
                );


            return new JwtSecurityTokenHandler().WriteToken(jwt);

        }

    }
}
