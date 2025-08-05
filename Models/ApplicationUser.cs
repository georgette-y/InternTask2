using Microsoft.AspNetCore.Identity;


namespace InternTask2.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }  // Extra user info (optional)
    }
}
