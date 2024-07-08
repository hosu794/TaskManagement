using Microsoft.AspNetCore.Identity;

namespace Core.Models.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
