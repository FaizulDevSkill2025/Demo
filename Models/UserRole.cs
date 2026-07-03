using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class UserRole
    {
        [Key]
        public int UserRoleId { get; set; }
        public required int UserId { get; set; }
        public required int RoleId { get; set; }
    }
}
