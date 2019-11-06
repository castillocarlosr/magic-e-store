using System;
using Microsoft.AspNetCore.Identity;

namespace magic_e_Shop.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string UserName { get; set; }
    }

    public static class ApplicationRoles
    {
        public const string Member = "Member";
        public const string Admin = "Admin";
        public const string SpecialUser = "SpecialUser";
    }
}
