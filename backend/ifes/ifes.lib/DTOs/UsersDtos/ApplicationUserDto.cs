using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.lib.DTOs.UsersDtos {
    public class ApplicationUserDto :IdentityUser<Guid>{
    }
}
