using Microsoft.AspNetCore.Identity;

namespace MyOnlineStore.Models
{
    public class AppUser : IdentityUser
    {
        public string Occupation { get; set; } 
    }
}
