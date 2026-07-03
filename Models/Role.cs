using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [StringLength(50)]
        public required string RoleName { get; set; }
        [StringLength(200)]
        public string? RoleDescription { get; set; }
    }
}
