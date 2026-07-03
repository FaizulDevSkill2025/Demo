using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class VerifyEmail
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
