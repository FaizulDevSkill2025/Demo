using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Users: IdentityUser
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(50)]
        public required string UserName { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public required string Email { get; set; }

        [StringLength(20)]
        public required string Password { get; set; }
    }
}
