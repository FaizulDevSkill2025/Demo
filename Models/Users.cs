using Microsoft.AspNetCore.Identity;

namespace Demo.Models
{
    public class Users: IdentityUser
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
    }
}
